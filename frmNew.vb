Public Class frmNew

    Dim TotalRAM As Integer
    Private Sub frmNew_Load(sender As Object, e As System.EventArgs) Handles Me.Load
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
            cmdBack.Enabled = True
            pansubPage1.BringToFront()
            pansubPage1.Visible = True
            pansubPage0.Visible = False
            SetRecommendedHw()
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

    Private Sub SetRecommendedHw()
        Select Case Page0VersionCmb.SelectedItem.ToString
            Case "Mac OS X 10.2 Cheetah"
                Page1MemoryRecLabel.Text = "The recommended memory size is 128 MB"
                If Page1MemoryNumUD.Value = 0 Then
                    Page1MemoryNumUD.Value = 128
                End If
            Case "Mac OS X 10.3 Panther"
                Page1MemoryRecLabel.Text = "The recommended memory size is 128 MB"
                If Page1MemoryNumUD.Value = 0 Then
                    Page1MemoryNumUD.Value = 128
                End If
            Case "Mac OS X 10.4 Tiger"
                Page1MemoryRecLabel.Text = "The recommended memory size is 256 MB"
                If Page1MemoryNumUD.Value = 0 Then
                    Page1MemoryNumUD.Value = 256
                End If
            Case "Other Mac OS X"
                Page1MemoryRecLabel.Text = "The recommended memory size is 128 MB"
                If Page1MemoryNumUD.Value = 0 Then
                    Page1MemoryNumUD.Value = 128
                End If
            Case "Debian"
                Page1MemoryRecLabel.Text = "The recommended memory size is 256 MB"
                If Page1MemoryNumUD.Value = 0 Then
                    Page1MemoryNumUD.Value = 256
                End If
            Case "Ubuntu"
                Page1MemoryRecLabel.Text = "The recommended memory size is 384 MB"
                If Page1MemoryNumUD.Value = 0 Then
                    Page1MemoryNumUD.Value = 384
                End If
            Case "Other"
                Page1MemoryRecLabel.Text = "The recommended memory size is 128 MB"
                If Page1MemoryNumUD.Value = 0 Then
                    Page1MemoryNumUD.Value = 128
                End If
        End Select
    End Sub

    Private Sub CreateMac()
        With frmMain.lvVmlist.Items.Add(Page0NameText.Text)
            Select Case Page0VersionCmb.SelectedItem.ToString
                Case "Mac OS X 10.2 Cheetah"
                    .ImageIndex = 2
                Case "Mac OS X 10.3 Panther"
                    .ImageIndex = 3
                Case "Mac OS X 10.4 Tiger"
                    .ImageIndex = 4
                Case "Other Mac OS X"
                    .ImageIndex = 1
                Case "Debian"
                    .ImageIndex = 5
                Case "Ubuntu"
                    .ImageIndex = 5
                Case "Other"
                    .ImageIndex = 0
            End Select
        End With
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As ComboBox, e As System.EventArgs) Handles Page0FamilyCmb.SelectedIndexChanged
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
            Page2DiskLocBrowseBtn.Enabled = False
            Page2DiskLocTxt.Enabled = False
        Else
            Page2DiskLocBrowseBtn.Enabled = True
            Page2DiskLocTxt.Enabled = True
        End If
    End Sub

    Private Sub Page1MemorySldr_ValueChanged(sender As TrackBar, e As System.EventArgs) Handles Page1MemorySldr.ValueChanged
        Page1MemoryNumUD.Value = sender.Value
    End Sub

    Private Sub Page1MemoryNumUD_ValueChanged(sender As NumericUpDown, e As System.EventArgs) Handles Page1MemoryNumUD.ValueChanged
        Page1MemorySldr.Value = sender.Value
    End Sub

    Private Sub Page0NameText_TextChanged(sender As TextBox, e As System.EventArgs) Handles Page0NameText.TextChanged
        If sender.Text = "" Then
            cmdNext.Enabled = False
        Else
            cmdNext.Enabled = True
        End If
    End Sub
End Class