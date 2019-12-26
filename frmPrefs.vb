Public Class frmPrefs

    Private Sub frmPrefs_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Select Case My.Settings.UpdateSetting
            Case 0
                Update0.Checked = True
            Case 1
                Update1.Checked = True
            Case 2
                Update2.Checked = True
            Case 3
                Update3.Checked = True
        End Select
        
        If My.Settings.PPCExecutable <> "" Then
            PathsPPCExecutable.Items.Add(My.Settings.PPCExecutable)
            PathsPPCExecutable.SelectedIndex = 1
        End If
        If My.Settings.DefaultNewMacPath <> "" Then
            PathsDefaultPath.Items.Add(My.Settings.DefaultNewMacPath)
            PathsDefaultPath.SelectedIndex = 1
        End If
        PathsRandomMsg.Checked = My.Settings.RandomTitles
        SectionPicker.FocusedItem = SectionPicker.Items.Item(0)

        Select Case My.Settings.Locale
            Case Else
                ComboBox1.Items.Add(My.Settings.Locale)
        End Select
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub cmdOK_Click(sender As System.Object, e As System.EventArgs) Handles cmdOK.Click
        If Update0.Checked Then
            My.Settings.UpdateSetting = 0
        ElseIf Update1.Checked Then
            My.Settings.UpdateSetting = 1
        ElseIf Update2.Checked Then
            My.Settings.UpdateSetting = 2
        ElseIf Update3.Checked Then
            My.Settings.UpdateSetting = 3
        End If

        My.Settings.PPCExecutable = PathsPPCExecutable.Text
        My.Settings.DefaultNewMacPath = PathsDefaultPath.Text
        My.Settings.RandomTitles = PathsRandomMsg.Checked
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub SectionPicker_Click(sender As Object, e As System.EventArgs) Handles SectionPicker.Click
        Select Case SectionPicker.FocusedItem.Index
            Case 0
                LanguageContainer.BringToFront()
            Case 1
                PathsContainer.BringToFront()
            Case 2
                UpdatesContainer.BringToFront()
        End Select
    End Sub

    Private Sub PathsDefaultPath_SelectedIndexChanged(sender As ComboBox, e As System.EventArgs) Handles PathsDefaultPath.SelectedIndexChanged
        If PathsDefaultPath.SelectedIndex = 0 Then
            If FolderBrowserDialog1.ShowDialog = 1 Then
                PathsDefaultPath.Items.Add(FolderBrowserDialog1.SelectedPath)
                PathsDefaultPath.SelectedIndex = PathsDefaultPath.Items.Count - 1
            Else
                If My.Settings.DefaultNewMacPath = "" Then
                    PathsDefaultPath.SelectedIndex = -1
                    PathsDefaultPath.Text = ""
                Else
                    PathsDefaultPath.SelectedIndex = 1
                End If
            End If
        End If
    End Sub

    Private Sub PathsPPCExecutable_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles PathsPPCExecutable.SelectedIndexChanged
        If PathsPPCExecutable.SelectedIndex = 0 Then
            If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                PathsPPCExecutable.Items.Add(OpenFileDialog1.FileName)
                PathsPPCExecutable.SelectedIndex = PathsPPCExecutable.Items.Count - 1
            Else
                If My.Settings.PPCExecutable = "" Then
                    PathsPPCExecutable.SelectedIndex = -1
                    PathsPPCExecutable.Text = ""
                Else
                    PathsPPCExecutable.SelectedIndex = 1
                End If
            End If
        End If
    End Sub
End Class