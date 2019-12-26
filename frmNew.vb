Imports System.IO.Path
Public Class frmNew
    Dim MacParentPath As String = My.Settings.DefaultNewMacPath
    Dim TotalRAM As Integer
    Private Sub frmNew_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If My.Settings.DefaultNewMacPath = "" Then
            MsgBox("The default Mac path is not set. Please set it before trying to create a new Mac.", MsgBoxStyle.Exclamation, frmMain.Fortune)
            Me.Close()
        End If
        Page0FamilyCmb.SelectedIndex = 0
        TotalRAM = Math.Round((((My.Computer.Info.TotalPhysicalMemory) / 1024) / 1024), 0)
        Page1MemorySldr.Maximum = TotalRAM
        Page1MemorySldr.TickFrequency = TotalRAM / 20
        Page1MemoryNumUD.Maximum = TotalRAM
    End Sub

    Private Sub cmdCancel_Click(sender As Button, e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdBack_Click(sender As Button, e As System.EventArgs) Handles cmdBack.Click
        If pansubPage2.Visible = True Then
            pansubPage1.BringToFront()
            pansubPage1.Visible = True
            pansubPage2.Visible = False
        ElseIf pansubPage1.Visible = True Then
            pansubPage0.BringToFront()
            pansubPage0.Visible = True
            pansubPage1.Visible = False
            sender.Enabled = False
        End If
    End Sub

    Private Sub cmdNext_Click(sender As Button, e As System.EventArgs) Handles cmdNext.Click
        If pansubPage0.Visible = True Then
            If My.Computer.FileSystem.DirectoryExists(My.Settings.DefaultNewMacPath & DirectorySeparatorChar & Page0NameText.Text) Then
                MsgBox(My.Resources.frmNewAlreadyExists_en, MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            SetRecommendedHw()
            cmdBack.Enabled = True
            pansubPage1.BringToFront()
            pansubPage1.Visible = True
            pansubPage0.Visible = False
        ElseIf pansubPage1.Visible = True Then
            pansubPage2.BringToFront()
            pansubPage2.Visible = True
            pansubPage1.Visible = False
        ElseIf pansubPage2.Visible = True Then
            sender.Enabled = False
            CreateMac()
            Me.Close()
        End If
    End Sub

    Private Sub CreateMac()
        Dim FileName As String = MacMaker.CreateMac(Page0NameText.Text, GetData())
        With frmMain.lvVmlist.Items.Add(Page0NameText.Text)
            Select Case Page0VersionCmb.SelectedItem.ToString
                Case "Mac OS X 10.2 Cheetah"
                    .SubItems.Add(FileName)
                    .ImageIndex = 2
                Case "Mac OS X 10.3 Panther"
                    .SubItems.Add(FileName)
                    .ImageIndex = 3
                Case "Mac OS X 10.4 Tiger"
                    .SubItems.Add(FileName)
                    .ImageIndex = 4
                Case "Other Mac OS X"
                    .SubItems.Add(FileName)
                    .ImageIndex = 1
                Case "Debian"
                    .SubItems.Add(FileName)
                    .ImageIndex = 5
                Case "Ubuntu"
                    .SubItems.Add(FileName)
                    .ImageIndex = 5
                Case "Other"
                    .SubItems.Add(FileName)
                    .ImageIndex = 0
            End Select
        End With
        ImageMaker.CreateFixed(Page2DiskNewSizeNumUD.Value, Page2DiskLocTxt.Text)
        ImageMaker.ShowDialog()
        frmMain.lvSaver()
    End Sub

    Private Function GetData() As String()
        Dim Memory As String = "0x" & (Page1MemoryNumUD.Value / 0.0000256)
        Dim MasterEnabled As String = "0"
        Dim MasterImage As String = ""

        If Page2NewRadio.Checked Or Page2ExistRadio.Checked Then
            MasterEnabled = "1"
            MasterImage = Page2DiskLocTxt.Text
        End If

        Return {Memory, MasterEnabled, MasterImage}
    End Function

    Private Sub SetRecommendedHw()
        Page2DiskLocTxt.Text = _
            My.Settings.DefaultNewMacPath & DirectorySeparatorChar & Page0NameText.Text & _
            DirectorySeparatorChar & Page0NameText.Text & ".dsk"
        Select Case Page0VersionCmb.SelectedItem.ToString
            Case "Mac OS X 10.2 Cheetah"
                Page1MemoryRecLabel.Text = "The recommended memory size is 128 MB"
                If Page1MemoryNumUD.Value = 0 Then
                    Page1MemoryNumUD.Value = 128
                End If
                If Page2DiskNewSizeNumUD.Value = 0 Then
                    Page2DiskNewSizeNumUD.Value = 2048
                End If
            Case "Mac OS X 10.3 Panther"
                Page1MemoryRecLabel.Text = "The recommended memory size is 128 MB"
                If Page1MemoryNumUD.Value = 0 Then
                    Page1MemoryNumUD.Value = 3072
                End If
                If Page2DiskNewSizeNumUD.Value = 0 Then
                    Page2DiskNewSizeNumUD.Value = 128
                End If
            Case "Mac OS X 10.4 Tiger"
                Page1MemoryRecLabel.Text = "The recommended memory size is 256 MB"
                If Page1MemoryNumUD.Value = 0 Then
                    Page1MemoryNumUD.Value = 256
                End If
                If Page2DiskNewSizeNumUD.Value = 0 Then
                    Page2DiskNewSizeNumUD.Value = 4096
                End If
            Case "Other Mac OS X"
                Page1MemoryRecLabel.Text = "The recommended memory size is 128 MB"
                If Page1MemoryNumUD.Value = 0 Then
                    Page1MemoryNumUD.Value = 128
                End If
                If Page2DiskNewSizeNumUD.Value = 0 Then
                    Page2DiskNewSizeNumUD.Value = 2048
                End If
            Case "Debian"
                Page1MemoryRecLabel.Text = "The recommended memory size is 256 MB"
                If Page1MemoryNumUD.Value = 0 Then
                    Page1MemoryNumUD.Value = 256
                End If
                If Page2DiskNewSizeNumUD.Value = 0 Then
                    Page2DiskNewSizeNumUD.Value = 6144
                End If
            Case "Ubuntu"
                Page1MemoryRecLabel.Text = "The recommended memory size is 384 MB"
                If Page1MemoryNumUD.Value = 0 Then
                    Page1MemoryNumUD.Value = 384
                End If
                If Page2DiskNewSizeNumUD.Value = 0 Then
                    Page2DiskNewSizeNumUD.Value = 6144
                End If
            Case "Other"
                Page1MemoryRecLabel.Text = "The recommended memory size is 128 MB"
                If Page1MemoryNumUD.Value = 0 Then
                    Page1MemoryNumUD.Value = 128
                End If
                If Page2DiskNewSizeNumUD.Value = 0 Then
                    Page2DiskNewSizeNumUD.Value = 4096
                End If
        End Select
    End Sub

    Private Sub Page0NameText_TextChanged(sender As TextBox, e As System.EventArgs) Handles Page0NameText.TextChanged
        If sender.Text = "" Then
            cmdNext.Enabled = False
        Else
            cmdNext.Enabled = True
        End If
    End Sub

    Private Sub Page0FamilyCmb_SelectedIndexChanged(sender As ComboBox, e As System.EventArgs) Handles Page0FamilyCmb.SelectedIndexChanged
        Select Case Page0FamilyCmb.SelectedIndex
            Case 0
                With Page0VersionCmb
                    .Items.Clear()
                    .Items.Add("Mac OS X 10.2 Cheetah")
                    .Items.Add("Mac OS X 10.3 Panther")
                    .Items.Add("Mac OS X 10.4 Tiger")
                    .Items.Add("Other Mac OS X")
                    .SelectedIndex = 0
                End With
            Case 1
                With Page0VersionCmb
                    .Items.Clear()
                    .Items.Add("Debian")
                    .Items.Add("Ubuntu")
                    .SelectedIndex = 0
                End With
            Case 2
                With Page0VersionCmb
                    .Items.Clear()
                    .Items.Add("Other")
                    .SelectedIndex = 0
                End With
        End Select
    End Sub

    Private Sub Page1MemorySldr_ValueChanged(sender As TrackBar, e As System.EventArgs) Handles Page1MemorySldr.ValueChanged
        Page1MemoryNumUD.Value = sender.Value
    End Sub

    Private Sub Page1MemoryNumUD_ValueChanged(sender As NumericUpDown, e As System.EventArgs) Handles Page1MemoryNumUD.ValueChanged
        Page1MemorySldr.Value = sender.Value
    End Sub

    Private Sub Page2DiskLocBrowseBtn_Click(sender As System.Object, e As System.EventArgs) Handles Page2DiskLocBrowseBtn.Click
        If Page2ExistRadio.Checked Then
            If OpenFile.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                Page2DiskLocTxt.Text = OpenFile.FileName
                OpenFile.FileName = ""
            End If
        ElseIf Page2NewRadio.Checked Then
            If SaveFile.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                Page2DiskLocTxt.Text = SaveFile.FileName
                SaveFile.FileName = ""
            End If
        End If
    End Sub

    Private Sub Page2NewRadio_CheckedChanged(sender As RadioButton, e As System.EventArgs) Handles Page2NewRadio.CheckedChanged
        If sender.Checked Then
            Page2DiskNewSizeLabel.Visible = True
            Page2DiskNewSizeNumUD.Visible = True
        Else
            Page2DiskNewSizeLabel.Visible = False
            Page2DiskNewSizeNumUD.Visible = False
        End If
    End Sub

    Private Sub Page2NoneRadio_CheckedChanged(sender As RadioButton, e As System.EventArgs) Handles Page2NoneRadio.CheckedChanged
        If sender.Checked Then
            cmdNext.Enabled = True
            Page2DiskLocBrowseBtn.Enabled = False
            Page2DiskLocTxt.Enabled = False
        Else
            Page2DiskLocBrowseBtn.Enabled = True
            Page2DiskLocTxt.Enabled = True
            Page2DiskLocTxt_TextChanged(Page2DiskLocTxt, System.EventArgs.Empty)
        End If
    End Sub

    Private Sub Page2DiskLocTxt_TextChanged(sender As TextBox, e As System.EventArgs) Handles Page2DiskLocTxt.TextChanged
        If sender.Text = "" Then
            cmdNext.Enabled = False
        Else
            cmdNext.Enabled = True
        End If
    End Sub

    Private Sub Page0VersionCmb_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles Page0VersionCmb.SelectedIndexChanged
        Select Case Page0VersionCmb.Text
            Case "Mac OS X 10.2 Cheetah"
                Page0OSPic.Image = My.Resources.Cheetah
            Case "Mac OS X 10.3 Panther"
                Page0OSPic.Image = My.Resources.Panther
            Case "Mac OS X 10.4 Tiger"
                Page0OSPic.Image = My.Resources.Tiger
            Case "Other Mac OS X"
                Page0OSPic.Image = My.Resources.GenericMacOS
            Case "Debian"
                Page0OSPic.Image = My.Resources.Linux
            Case "Ubuntu"
                Page0OSPic.Image = My.Resources.Linux
            Case "Other"
                Page0OSPic.Image = My.Resources.Other
        End Select
    End Sub
End Class