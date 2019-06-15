Imports System.IO.Path
Public Class frmMain
    Private Sub tbActionNew_Click(sender As System.Object, e As System.EventArgs) Handles tbActionNew.Click
        frmNew.Show()
    End Sub

    Private Sub tbActionConfig_Click(sender As System.Object, e As System.EventArgs) Handles tbActionConfig.Click
        frmSettings.Show()
    End Sub

    Private Sub tbDelete_Click(sender As System.Object, e As System.EventArgs) Handles tbDelete.Click
        If lvVmlist.FocusedItem.Index <> -1 Then
            'If frmMainDelete.ShowDialog = 
            lvVmlist.FocusedItem.Remove()
            If lvVmlist.Items.Count = 0 Then
                tbDelete.Enabled = False
            Else
                With lvVmlist.Items.Item(lvVmlist.Items.Count - 1)
                    .EnsureVisible()
                    .Selected = True
                End With
            End If
        End If
    End Sub

    Private Sub tbStart_Click(sender As System.Object, e As System.EventArgs) Handles tbStart.Click
        StartPPC()
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

    Private Sub MenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles MenuItem1.Click
        frmDebug.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'You could use any VM* setting. All of them will have the same count
        Dim Names As String() = Split(My.Settings.VMNames, Chr(34))
        Dim Paths As String() = Split(My.Settings.VMPaths, Chr(34))
        Dim Icons As String() = Split(My.Settings.VMIcons, Chr(34))

        If Names.Length > 1 Then
            For x As Integer = 0 To Names.Length - 1
                With lvVmlist.Items.Add(Names(x))
                    '.ImageIndex = Icons(x)
                    .SubItems.Add(Paths(x))
                End With
            Next
        End If

        If My.Settings.DefaultNewMacPath = "" Then
            MsgBox("The default Mac path is not set. Please set it before trying to create a new Mac.", MsgBoxStyle.Exclamation, Fortune)
        End If
        Me.Location = My.Settings.LastLocation
        Me.Size = My.Settings.LastSize
        Me.WindowState = My.Settings.LastWindowState
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If lvVmlist.Items.Count > 0 Then
            For x As Integer = 0 To lvVmlist.Items.Count - 1
                My.Settings.VMIcons = My.Settings.VMIcons & lvVmlist.Items.Item(x).ImageIndex & Chr(34)
                MsgBox(My.Settings.VMIcons & lvVmlist.Items.Item(x).ImageIndex & Chr(34))
                My.Settings.VMNames = My.Settings.VMNames & lvVmlist.Items.Item(x).Text & Chr(34)
                My.Settings.VMPaths = My.Settings.VMPaths & lvVmlist.Items.Item(x).SubItems.Item(1).Text & Chr(34)
            Next
        End If

        My.Settings.LastWindowState = Me.WindowState
        If Not Me.WindowState = FormWindowState.Maximized Then
            My.Settings.LastLocation = Me.Location
            My.Settings.LastSize = Me.Size
        End If
        My.Settings.Save()
        'Fix for menus disappearing before the whole form
        Me.Visible = False
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        panMain.Width = Me.ClientSize.Width - panMain.Left
        panMain.Height = Me.ClientSize.Height - panMain.Top
    End Sub

    Private Sub panDetCollapse_Click(sender As Button, e As System.EventArgs) Handles panDetSysCollapse.Click, panDetKeysCollapse.Click, panDetBootCollapse.Click, panDetNetCollapse.Click
        Dim ParentPanel As Panel = sender.Parent
        Dim SubPanel As Panel = ParentPanel.Controls.Item(3)
        If ParentPanel.Height > SubPanel.Height Then
            ParentPanel.Height = ParentPanel.Height - SubPanel.Height
            SubPanel.Enabled = False
            sender.BackgroundImage = My.Resources.ArrowDown
        Else
            ParentPanel.Height = ParentPanel.Height + SubPanel.Height
            SubPanel.Enabled = True
            sender.BackgroundImage = My.Resources.ArrowUp
        End If
    End Sub

    Private Sub panDetail_Resize(sender As Object, e As System.EventArgs) Handles panMain.Resize
        panMain.Refresh()
        If Not panMain.Width <= panWelcomeTitle.Width + panWelcomePic.Width Then
            panWelcomePic.Left = panMain.Width - panWelcomePic.Width - 10
            panWelcomeDescription.Width = panMain.Width - panWelcomePic.Width - 9
        End If
    End Sub

    Private Sub panDetFlowContainer_Resize(sender As FlowLayoutPanel, e As System.EventArgs) Handles panDetFlowContainer.Resize
        For x As Integer = 0 To sender.Controls.Count - 1
            sender.Controls.Item(x).Width = sender.Width - 15
            If sender.Controls.Item(x).Controls.Count > 3 Then
                sender.Controls.Item(x).Controls.Item(3).Width = sender.Controls.Item(x).Width - 7
                sender.Controls.Item(x).Controls.Item(2).Left = _
                    sender.Controls.Item(x).Width - _
                    sender.Controls.Item(x).Controls.Item(2).Width
            End If
        Next
    End Sub

    Private Sub lvVmlist_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvVmlist.SelectedIndexChanged
        If IsNothing(lvVmlist.FocusedItem) = True Then
            QuickButtons(False)
        Else
            QuickButtons(True)
        End If
    End Sub

    Private Sub Link_MouseEnter(sender As Object, e As System.EventArgs) Handles panDetSysLink.MouseEnter, panDetKeysLink.MouseEnter, panDetBootLink.MouseEnter, panDetNetLink.MouseEnter
        sender.LinkColor = Color.Blue
    End Sub

    Private Sub Link_MouseLeave(sender As Object, e As System.EventArgs) Handles panDetSysLink.MouseLeave, panDetKeysLink.MouseLeave, panDetBootLink.MouseLeave, panDetNetLink.MouseLeave
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

    Private Sub StartPPC()

    End Sub
End Class
