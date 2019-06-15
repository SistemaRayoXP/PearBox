Public Class frmDisk
    Private Sub cmdCancel_Click(sender As Button, e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdBack_Click(sender As Button, e As System.EventArgs) Handles cmdBack.Click
        If pansubPage1.Visible = True Then
            sender.Enabled = False
            pansubPage0.BringToFront()
            pansubPage0.Visible = True
            pansubPage1.Visible = False
        End If
    End Sub

    Private Sub cmdNext_Click(sender As Button, e As System.EventArgs) Handles cmdNext.Click
        If pansubPage0.Visible = True Then
            cmdBack.Enabled = True
            pansubPage1.BringToFront()
            pansubPage1.Visible = True
            pansubPage0.Visible = False
            CheckFixed()
        ElseIf pansubPage1.Visible = True Then
            sender.Enabled = False
            CreateDisk()
            Me.Close()
        End If
    End Sub

    Private Sub CheckFixed()
        If Page0DisktypeCmb.SelectedIndex <> 0 Then
            Page1DiskNewSizeLabel.Visible = False
            Page1DiskNewSizeNumUD.Visible = False
        Else
            Page1DiskNewSizeLabel.Visible = True
            Page1DiskNewSizeNumUD.Visible = True
        End If
    End Sub

    Private Sub CreateDisk()
        Select Case Page0DisktypeCmb.SelectedIndex
            Case 0
                ImageMaker.CreateFixed(Page1DiskNewSizeNumUD.Value, Page1DiskLocTxt.Text)
                ImageMaker.ShowDialog()
            Case 1
                ImageMaker.CreateRemovable("144Blank", Page1DiskLocTxt.Text)
            Case 2
                ImageMaker.CreateRemovable("144Boot68K70", Page1DiskLocTxt.Text)
            Case 3
                ImageMaker.CreateRemovable("144BootPPC85", Page1DiskLocTxt.Text)
        End Select
        Dispose()
    End Sub

    Private Sub Page1DiskLocBrowseBtn_Click(sender As System.Object, e As System.EventArgs) Handles Page1DiskLocBrowseBtn.Click
        If SaveFile.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Page1DiskLocTxt.Text = SaveFile.FileName
            SaveFile.FileName = ""
        End If
    End Sub

    Private Sub frmDisk_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Page0DisktypeCmb.SelectedIndex = 0
    End Sub
End Class