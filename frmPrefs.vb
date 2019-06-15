Public Class frmPrefs

    Private Sub tabMainNewmacsBrowse_Click(sender As System.Object, e As System.EventArgs) Handles tabMainNewmacsBrowse.Click
        If FolderBrowserDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            tabMainNewmacsTxt.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub cmdOK_Click(sender As System.Object, e As System.EventArgs) Handles cmdOK.Click
        My.Settings.DefaultNewMacPath = tabMainNewmacsTxt.Text
        My.Settings.RandomTitles = tabMainRandomChk.Checked
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub frmPrefs_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        tabMainNewmacsTxt.Text = My.Settings.DefaultNewMacPath
        tabMainRandomChk.Checked = My.Settings.RandomTitles
    End Sub
End Class