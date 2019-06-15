<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrefs
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.prefs = New System.Windows.Forms.TabControl()
        Me.prefsTabMain = New System.Windows.Forms.TabPage()
        Me.tabMainNewmacsBrowse = New System.Windows.Forms.Button()
        Me.tabMainNewmacsLabel = New System.Windows.Forms.Label()
        Me.tabMainNewmacsTxt = New System.Windows.Forms.TextBox()
        Me.prefsTabUpdates = New System.Windows.Forms.TabPage()
        Me.prefsTabLanguage = New System.Windows.Forms.TabPage()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.tabMainRandomChk = New System.Windows.Forms.CheckBox()
        Me.prefs.SuspendLayout()
        Me.prefsTabMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'prefs
        '
        Me.prefs.Controls.Add(Me.prefsTabMain)
        Me.prefs.Controls.Add(Me.prefsTabUpdates)
        Me.prefs.Controls.Add(Me.prefsTabLanguage)
        Me.prefs.Location = New System.Drawing.Point(9, 9)
        Me.prefs.Margin = New System.Windows.Forms.Padding(0, 0, 0, 30)
        Me.prefs.Name = "prefs"
        Me.prefs.SelectedIndex = 0
        Me.prefs.Size = New System.Drawing.Size(468, 278)
        Me.prefs.TabIndex = 1
        '
        'prefsTabMain
        '
        Me.prefsTabMain.Controls.Add(Me.tabMainRandomChk)
        Me.prefsTabMain.Controls.Add(Me.tabMainNewmacsBrowse)
        Me.prefsTabMain.Controls.Add(Me.tabMainNewmacsLabel)
        Me.prefsTabMain.Controls.Add(Me.tabMainNewmacsTxt)
        Me.prefsTabMain.Location = New System.Drawing.Point(4, 22)
        Me.prefsTabMain.Name = "prefsTabMain"
        Me.prefsTabMain.Size = New System.Drawing.Size(460, 252)
        Me.prefsTabMain.TabIndex = 0
        Me.prefsTabMain.Text = "Main"
        Me.prefsTabMain.UseVisualStyleBackColor = True
        '
        'tabMainNewmacsBrowse
        '
        Me.tabMainNewmacsBrowse.Location = New System.Drawing.Point(376, 29)
        Me.tabMainNewmacsBrowse.Name = "tabMainNewmacsBrowse"
        Me.tabMainNewmacsBrowse.Size = New System.Drawing.Size(75, 23)
        Me.tabMainNewmacsBrowse.TabIndex = 2
        Me.tabMainNewmacsBrowse.Text = "Browse"
        Me.tabMainNewmacsBrowse.UseVisualStyleBackColor = True
        '
        'tabMainNewmacsLabel
        '
        Me.tabMainNewmacsLabel.AutoSize = True
        Me.tabMainNewmacsLabel.Location = New System.Drawing.Point(3, 34)
        Me.tabMainNewmacsLabel.Name = "tabMainNewmacsLabel"
        Me.tabMainNewmacsLabel.Size = New System.Drawing.Size(151, 13)
        Me.tabMainNewmacsLabel.TabIndex = 3
        Me.tabMainNewmacsLabel.Text = "Default location for new Macs:"
        '
        'tabMainNewmacsTxt
        '
        Me.tabMainNewmacsTxt.Location = New System.Drawing.Point(160, 31)
        Me.tabMainNewmacsTxt.Name = "tabMainNewmacsTxt"
        Me.tabMainNewmacsTxt.Size = New System.Drawing.Size(210, 20)
        Me.tabMainNewmacsTxt.TabIndex = 4
        '
        'prefsTabUpdates
        '
        Me.prefsTabUpdates.Location = New System.Drawing.Point(4, 22)
        Me.prefsTabUpdates.Name = "prefsTabUpdates"
        Me.prefsTabUpdates.Size = New System.Drawing.Size(460, 252)
        Me.prefsTabUpdates.TabIndex = 1
        Me.prefsTabUpdates.Text = "Updates"
        Me.prefsTabUpdates.UseVisualStyleBackColor = True
        '
        'prefsTabLanguage
        '
        Me.prefsTabLanguage.Location = New System.Drawing.Point(4, 22)
        Me.prefsTabLanguage.Name = "prefsTabLanguage"
        Me.prefsTabLanguage.Size = New System.Drawing.Size(460, 252)
        Me.prefsTabLanguage.TabIndex = 2
        Me.prefsTabLanguage.Text = "Language"
        Me.prefsTabLanguage.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Select the path where the new Macs will be saved"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(318, 291)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 3
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(399, 291)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'tabMainRandomChk
        '
        Me.tabMainRandomChk.AutoSize = True
        Me.tabMainRandomChk.Location = New System.Drawing.Point(6, 67)
        Me.tabMainRandomChk.Name = "tabMainRandomChk"
        Me.tabMainRandomChk.Size = New System.Drawing.Size(243, 17)
        Me.tabMainRandomChk.TabIndex = 6
        Me.tabMainRandomChk.Text = "Enable random messages in the title of dialogs"
        Me.tabMainRandomChk.UseVisualStyleBackColor = True
        '
        'frmPrefs
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(486, 326)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.prefs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPrefs"
        Me.Text = "PearBox preferences"
        Me.prefs.ResumeLayout(False)
        Me.prefsTabMain.ResumeLayout(False)
        Me.prefsTabMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents prefs As System.Windows.Forms.TabControl
    Friend WithEvents prefsTabMain As System.Windows.Forms.TabPage
    Friend WithEvents tabMainNewmacsBrowse As System.Windows.Forms.Button
    Friend WithEvents tabMainNewmacsLabel As System.Windows.Forms.Label
    Friend WithEvents tabMainNewmacsTxt As System.Windows.Forms.TextBox
    Friend WithEvents prefsTabUpdates As System.Windows.Forms.TabPage
    Friend WithEvents prefsTabLanguage As System.Windows.Forms.TabPage
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents tabMainRandomChk As System.Windows.Forms.CheckBox
End Class
