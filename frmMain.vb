Imports System.IO.Path
Imports System.Diagnostics.Process
Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If My.Settings.VMNames <> "" Then
            Dim Names As String() = Split(My.Settings.VMNames, Chr(34))
            Dim Paths As String() = Split(My.Settings.VMPaths, Chr(34))
            Dim Icons As String() = Split(My.Settings.VMIcons, Chr(34))

            For x As Integer = 0 To Names.Length - 2
                With lvVmlist.Items.Add(Names(x))
                    .ImageIndex = Icons(x)
                    .SubItems.Add(Paths(x))
                End With
            Next
        End If

        If My.Settings.Locale = "" Then
            My.Settings.Locale = My.Application.UICulture.Name
        End If

        Try
            If My.Settings.DefaultNewMacPath = "" Then
                'If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments _
                '& "\" & My.Settings.DefaultNewMacPath) Then
                My.Computer.FileSystem.CreateDirectory( _
                    My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & My.Resources.DefaultMacPath_en)
                My.Settings.DefaultNewMacPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & My.Resources.DefaultMacPath_en
                'End If
            End If
        Catch exc As Exception
            MsgBox(exc.Message, MsgBoxStyle.Critical, Fortune)
            MsgBox(My.Resources.frmMainErrorCreatingDefaultMacPath, MsgBoxStyle.Exclamation, Fortune)
        End Try
        Me.Location = My.Settings.LastLocation
        Me.Size = My.Settings.LastSize
        Me.WindowState = My.Settings.LastWindowState
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.LastWindowState = Me.WindowState
        If Not Me.WindowState = FormWindowState.Maximized Then
            My.Settings.LastLocation = Me.Location
            My.Settings.LastSize = Me.Size
        End If

        lvSaver()
        My.Settings.Save()
        'Fix for menus disappearing before the whole form
        Me.Visible = False
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        'panMain.Width = Me.ClientSize.Width - panMain.Left
        'panMain.Height = Me.ClientSize.Height - panMain.Top
    End Sub

    Public Sub lvSaver()
        My.Settings.VMNames = ""
        My.Settings.VMIcons = ""
        My.Settings.VMPaths = ""

        If lvVmlist.Items.Count > 0 Then
            For x As Integer = 0 To lvVmlist.Items.Count - 1
                My.Settings.VMNames = My.Settings.VMNames & lvVmlist.Items.Item(x).Text & Chr(34)
                My.Settings.VMIcons = My.Settings.VMIcons & lvVmlist.Items.Item(x).ImageIndex & Chr(34)
                My.Settings.VMPaths = My.Settings.VMPaths & lvVmlist.Items.Item(x).SubItems.Item(1).Text & Chr(34)
            Next
        End If
        My.Settings.Save()
    End Sub

    Private Sub mnuFilePrefs_Click(sender As System.Object, e As System.EventArgs) Handles mnuFilePrefs.Click
        frmPrefs.Show()
    End Sub

    Private Sub mnuFileDiskmaker_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileDiskmaker.Click
        frmDisk.Show()
    End Sub

    Private Sub mnuMachineNew_Click(sender As System.Object, e As System.EventArgs) Handles mnuMachineNew.Click
        frmNew.Show()
    End Sub

    Private Sub mnuMachineImport_Click(sender As System.Object, e As System.EventArgs) Handles mnuMachineImport.Click
        If Importer.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            With lvVmlist.Items.Add(GetFileNameWithoutExtension(Importer.FileName))
                .SubItems.Add(Importer.FileName)
                .ImageIndex = 0
            End With
        End If
    End Sub

    Private Sub mnuMachineExport_Click(sender As System.Object, e As System.EventArgs) Handles mnuMachineExport.Click
        Exporter.FileName = GetFileName(lvVmlist.FocusedItem.SubItems.Item(1).Text)
        If Exporter.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            FileCopy(lvVmlist.FocusedItem.SubItems.Item(1).Text, Exporter.FileName)
        End If
    End Sub

    Private Sub mnuHelpContents_Click(sender As System.Object, e As System.EventArgs) Handles mnuHelpContents.Click

    End Sub

    Private Sub mnuHelpAbout_Click(sender As System.Object, e As System.EventArgs) Handles mnuHelpAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub mnuHelpDebugWnd_Click(sender As System.Object, e As System.EventArgs) Handles mnuHelpDebugWnd.Click
        frmDebug.Show()
    End Sub

    Private Sub tbNew_Click(sender As System.Object, e As System.EventArgs) Handles tbActionNew.Click
        frmNew.Show()
    End Sub

    Private Sub tbConfig_Click(sender As System.Object, e As System.EventArgs) Handles tbActionConfig.Click
        frmSettings.FileName = lvVmlist.FocusedItem.SubItems.Item(1).Text
        frmSettings.Show()
    End Sub

    Private Sub tbDelete_Click(sender As System.Object, e As System.EventArgs) Handles tbDelete.Click
        If lvVmlist.FocusedItem.Index <> -1 Then
            Select Case frmMainDelete.ShowDialog
                Case Windows.Forms.DialogResult.Yes
                    Try
                        My.Computer.FileSystem.DeleteDirectory( _
                            System.IO.Path.GetDirectoryName(lvVmlist.FocusedItem.SubItems.Item(1).Text), _
                              FileIO.UIOption.OnlyErrorDialogs, _
                              FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
                        lvVmlist.FocusedItem.Remove()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation, Fortune)
                    End Try
                Case Windows.Forms.DialogResult.No
                    lvVmlist.FocusedItem.Remove()
            End Select

            If lvVmlist.Items.Count = 0 Then
                QuickButtons(False)
            Else
                With lvVmlist.Items.Item(lvVmlist.Items.Count - 1)
                    .EnsureVisible()
                    .Selected = True
                End With
            End If
        End If
    End Sub

    Private Sub tbStart_Click(sender As System.Object, e As System.EventArgs) Handles tbStart.Click
        PPCSubProcess.RunWorkerAsync(lvVmlist.FocusedItem.SubItems.Item(1).Text)
    End Sub

    Private Sub panDetCollapse_Click(sender As Button, e As System.EventArgs) _
        Handles panDetSysCollapse.Click, panDetKeysCollapse.Click, panDetBootCollapse.Click, panDetNetCollapse.Click
        Dim ParentPanel As Panel = sender.Parent
        Dim SubPanel As Panel = ParentPanel.Controls.Item(3)
        If ParentPanel.Height > 20 Then
            ParentPanel.Height = ParentPanel.Height - 29
            SubPanel.Height = 0
            SubPanel.Enabled = False
            sender.BackgroundImage = My.Resources.ArrowDown
        Else
            ParentPanel.Height = ParentPanel.Height + 29
            SubPanel.Enabled = True
            SubPanel.Height = 29
            sender.BackgroundImage = My.Resources.ArrowUp
        End If
    End Sub
    
    Private Sub lvVmlist_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvVmlist.SelectedIndexChanged
        If IsNothing(lvVmlist.FocusedItem) = True Then
            QuickButtons(False)
        Else
            QuickButtons(True)
        End If
    End Sub

    Private Sub Link_MouseEnter(sender As Object, e As System.EventArgs) _
        Handles panDetSysLink.MouseEnter, panDetKeysLink.MouseEnter, panDetBootLink.MouseEnter, panDetNetLink.MouseEnter
        sender.LinkColor = Color.Blue
    End Sub

    Private Sub Link_MouseLeave(sender As Object, e As System.EventArgs) _
        Handles panDetSysLink.MouseLeave, panDetKeysLink.MouseLeave, panDetBootLink.MouseLeave, panDetNetLink.MouseLeave
        sender.LinkColor = Color.Black
    End Sub

    Private Sub QuickButtons(Enable As Boolean)
        If Enable = True Then
            tbActionConfig.Enabled = True
            tbDelete.Enabled = True
            tbStart.Enabled = True
            mnuMachineExport.Enabled = True
        Else
            tbActionConfig.Enabled = False
            tbDelete.Enabled = False
            tbStart.Enabled = False
            mnuMachineExport.Enabled = False
        End If
    End Sub

    Public Function Fortune() As String
        Dim assemblyName As String = My.Application.Info.AssemblyName
        If My.Settings.RandomTitles Then
            Dim num As Long = CLng(Math.Round(CDbl(CSng((Rnd() * 30.0!)))))
            Dim num1 As Long = num
            If (num1 <= CLng(29) AndAlso num1 >= CLng(0)) Then
                Select Case CInt(num1)
                    Case 0
                        assemblyName = "It wasn't my fault... it was programmer's fault."
                        Exit Select
                    Case 1
                        assemblyName = My.Computer.Name & " in action!"
                        Exit Select
                    Case 2
                        assemblyName = "The chickens couldn't fly..."
                        Exit Select
                    Case 3
                        assemblyName = "Why this keeps happening?"
                        Exit Select
                    Case 4
                        assemblyName = "You should take a rest."
                        Exit Select
                    Case 5
                        assemblyName = "Congratulations"
                        Exit Select
                    Case 6
                        assemblyName = "Steve did it."
                        Exit Select
                    Case 7
                        assemblyName = "Better get a real Mac"
                        Exit Select
                    Case 8
                        assemblyName = "Was it you?"
                        Exit Select
                    Case 9
                        assemblyName = "It's your fault."
                        Exit Select
                    Case 10
                        assemblyName = "OK COMPUTER"
                        Exit Select
                    Case 12
                        assemblyName = "VirtualBox"
                        Exit Select
                    Case 13
                        assemblyName = "Apple Support"
                        Exit Select
                    Case 14
                        assemblyName = "Go get tasty tacos."
                        Exit Select
                    Case 15
                        assemblyName = "You might achieve this the next time."
                        Exit Select
                    Case 16
                        assemblyName = "Sorry, my fault."
                        Exit Select
                    Case 17
                        assemblyName = "01110101"
                        Exit Select
                    Case 18
                        assemblyName = "PearBox"
                        Exit Select
                    Case 19
                        assemblyName = "Santa Claus is coming to the town."
                        Exit Select
                    Case 20
                        assemblyName = "Prove you are not a robot."
                        Exit Select
                    Case 21
                        assemblyName = "No AI detected."
                        Exit Select
                    Case 22
                        assemblyName = "Weapon Containment Device."
                        Exit Select
                    Case 23
                        assemblyName = "Listen to the radio!"
                        Exit Select
                    Case 24
                        assemblyName = "Emaculation - All about Macintosh emulation"
                        Exit Select
                    Case 25
                        assemblyName = "Open your skull, I'll be there..."
                        Exit Select
                    Case 26
                        assemblyName = "This is what you'll get..."
                        Exit Select
                    Case 27
                        assemblyName = "...when you mess with us."
                        Exit Select
                    Case 28
                        assemblyName = "...when I climb up the walls."
                        Exit Select
                    Case 29
                        assemblyName = "What's up, doc?"
                        Exit Select
                End Select
            End If
            assemblyName = assemblyName & " " & num1
        End If
        Return assemblyName
    End Function

    Private Sub mnuFileExit_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub PPCSubProcess_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles PPCSubProcess.DoWork
        StartPPC.Start(e.Argument.ToString)
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs)
        frmStdOut.Show()
    End Sub
End Class