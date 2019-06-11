Public Class frmMain
    Private Sub tbActionNew_Click(sender As System.Object, e As System.EventArgs) Handles tbActionNew.Click
        frmNew.Show()
    End Sub

    Private Sub tbActionConfig_Click(sender As System.Object, e As System.EventArgs) Handles tbActionConfig.Click
        frmSettings.Show()
    End Sub

    Private Sub tbDelete_Click(sender As System.Object, e As System.EventArgs) Handles tbDelete.Click
        If lvVmlist.FocusedItem.Index <> -1 Then
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

    Private Sub mnuMachineNew_Click(sender As System.Object, e As System.EventArgs) Handles mnuMachineNew.Click
        frmNew.Show()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As System.Object, e As System.EventArgs) Handles mnuHelpAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
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
        Else
            tbActionConfig.Enabled = False
            tbDelete.Enabled = False
            tbStart.Enabled = False
        End If
    End Sub
End Class
