<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisk
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDisk))
        Me.Page1DiskNewSizeLabel = New System.Windows.Forms.Label()
        Me.grpControls = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.Page1DiskNewSizeNumUD = New System.Windows.Forms.NumericUpDown()
        Me.Page1DiskLocTxt = New System.Windows.Forms.TextBox()
        Me.pansubPage1 = New System.Windows.Forms.Panel()
        Me.Page1DiskLocLabel = New System.Windows.Forms.Label()
        Me.Page1DiskLocBrowseBtn = New System.Windows.Forms.Button()
        Me.Page1DescriptionLabel = New System.Windows.Forms.Label()
        Me.Page1TitleLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pansubWizardPic = New System.Windows.Forms.Panel()
        Me.Page0TitleLabel = New System.Windows.Forms.Label()
        Me.pansubPage0 = New System.Windows.Forms.Panel()
        Me.Page0DisktypeLabel = New System.Windows.Forms.Label()
        Me.Page0DescriptionLabel = New System.Windows.Forms.Label()
        Me.Page0DisktypeCmb = New System.Windows.Forms.ComboBox()
        Me.panPages = New System.Windows.Forms.Panel()
        Me.SaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.grpControls.SuspendLayout()
        CType(Me.Page1DiskNewSizeNumUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pansubPage1.SuspendLayout()
        Me.pansubPage0.SuspendLayout()
        Me.panPages.SuspendLayout()
        Me.SuspendLayout()
        '
        'Page1DiskNewSizeLabel
        '
        Me.Page1DiskNewSizeLabel.AutoSize = True
        Me.Page1DiskNewSizeLabel.Location = New System.Drawing.Point(187, 155)
        Me.Page1DiskNewSizeLabel.Name = "Page1DiskNewSizeLabel"
        Me.Page1DiskNewSizeLabel.Size = New System.Drawing.Size(55, 13)
        Me.Page1DiskNewSizeLabel.TabIndex = 8
        Me.Page1DiskNewSizeLabel.Text = "Size (MB):"
        Me.Page1DiskNewSizeLabel.Visible = False
        '
        'grpControls
        '
        Me.grpControls.Controls.Add(Me.cmdCancel)
        Me.grpControls.Controls.Add(Me.cmdNext)
        Me.grpControls.Controls.Add(Me.cmdBack)
        Me.grpControls.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpControls.Location = New System.Drawing.Point(0, 291)
        Me.grpControls.Name = "grpControls"
        Me.grpControls.Size = New System.Drawing.Size(494, 53)
        Me.grpControls.TabIndex = 1
        Me.grpControls.TabStop = False
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(413, 19)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(332, 19)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(75, 23)
        Me.cmdNext.TabIndex = 2
        Me.cmdNext.Text = "Next >"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Enabled = False
        Me.cmdBack.Location = New System.Drawing.Point(256, 19)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(75, 23)
        Me.cmdBack.TabIndex = 1
        Me.cmdBack.Text = "< Back"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'Page1DiskNewSizeNumUD
        '
        Me.Page1DiskNewSizeNumUD.Location = New System.Drawing.Point(248, 153)
        Me.Page1DiskNewSizeNumUD.Maximum = New Decimal(New Integer() {131072, 0, 0, 0})
        Me.Page1DiskNewSizeNumUD.Name = "Page1DiskNewSizeNumUD"
        Me.Page1DiskNewSizeNumUD.Size = New System.Drawing.Size(75, 20)
        Me.Page1DiskNewSizeNumUD.TabIndex = 3
        Me.Page1DiskNewSizeNumUD.Visible = False
        '
        'Page1DiskLocTxt
        '
        Me.Page1DiskLocTxt.Location = New System.Drawing.Point(67, 126)
        Me.Page1DiskLocTxt.Name = "Page1DiskLocTxt"
        Me.Page1DiskLocTxt.Size = New System.Drawing.Size(175, 20)
        Me.Page1DiskLocTxt.TabIndex = 1
        '
        'pansubPage1
        '
        Me.pansubPage1.BackColor = System.Drawing.SystemColors.Window
        Me.pansubPage1.Controls.Add(Me.Page1DiskLocLabel)
        Me.pansubPage1.Controls.Add(Me.Page1DiskNewSizeLabel)
        Me.pansubPage1.Controls.Add(Me.Page1DiskNewSizeNumUD)
        Me.pansubPage1.Controls.Add(Me.Page1DiskLocTxt)
        Me.pansubPage1.Controls.Add(Me.Page1DiskLocBrowseBtn)
        Me.pansubPage1.Controls.Add(Me.Page1DescriptionLabel)
        Me.pansubPage1.Controls.Add(Me.Page1TitleLabel)
        Me.pansubPage1.Location = New System.Drawing.Point(143, 0)
        Me.pansubPage1.Name = "pansubPage1"
        Me.pansubPage1.Size = New System.Drawing.Size(357, 302)
        Me.pansubPage1.TabIndex = 3
        Me.pansubPage1.Visible = False
        '
        'Page1DiskLocLabel
        '
        Me.Page1DiskLocLabel.AutoSize = True
        Me.Page1DiskLocLabel.Location = New System.Drawing.Point(29, 129)
        Me.Page1DiskLocLabel.Name = "Page1DiskLocLabel"
        Me.Page1DiskLocLabel.Size = New System.Drawing.Size(32, 13)
        Me.Page1DiskLocLabel.TabIndex = 9
        Me.Page1DiskLocLabel.Text = "Path:"
        '
        'Page1DiskLocBrowseBtn
        '
        Me.Page1DiskLocBrowseBtn.Location = New System.Drawing.Point(248, 124)
        Me.Page1DiskLocBrowseBtn.Name = "Page1DiskLocBrowseBtn"
        Me.Page1DiskLocBrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.Page1DiskLocBrowseBtn.TabIndex = 2
        Me.Page1DiskLocBrowseBtn.Text = "Browse"
        Me.Page1DiskLocBrowseBtn.UseVisualStyleBackColor = True
        '
        'Page1DescriptionLabel
        '
        Me.Page1DescriptionLabel.AutoSize = True
        Me.Page1DescriptionLabel.Location = New System.Drawing.Point(29, 52)
        Me.Page1DescriptionLabel.Name = "Page1DescriptionLabel"
        Me.Page1DescriptionLabel.Size = New System.Drawing.Size(296, 39)
        Me.Page1DescriptionLabel.TabIndex = 1
        Me.Page1DescriptionLabel.Text = "Set the location where you wouldlike your image to be saved." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you are creati" & _
    "ng a fixed disk, you can also set the size."
        '
        'Page1TitleLabel
        '
        Me.Page1TitleLabel.AutoSize = True
        Me.Page1TitleLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Page1TitleLabel.Location = New System.Drawing.Point(28, 23)
        Me.Page1TitleLabel.Name = "Page1TitleLabel"
        Me.Page1TitleLabel.Size = New System.Drawing.Size(150, 19)
        Me.Page1TitleLabel.TabIndex = 0
        Me.Page1TitleLabel.Text = "Location and size"
        '
        'pansubWizardPic
        '
        Me.pansubWizardPic.BackgroundImage = Global.PearBox.My.Resources.Resources.WizardImage
        Me.pansubWizardPic.Dock = System.Windows.Forms.DockStyle.Left
        Me.pansubWizardPic.Location = New System.Drawing.Point(0, 0)
        Me.pansubWizardPic.Name = "pansubWizardPic"
        Me.pansubWizardPic.Size = New System.Drawing.Size(143, 302)
        Me.pansubWizardPic.TabIndex = 2
        '
        'Page0TitleLabel
        '
        Me.Page0TitleLabel.AutoSize = True
        Me.Page0TitleLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Page0TitleLabel.Location = New System.Drawing.Point(20, 23)
        Me.Page0TitleLabel.Name = "Page0TitleLabel"
        Me.Page0TitleLabel.Size = New System.Drawing.Size(85, 19)
        Me.Page0TitleLabel.TabIndex = 0
        Me.Page0TitleLabel.Text = "Disk type"
        '
        'pansubPage0
        '
        Me.pansubPage0.BackColor = System.Drawing.SystemColors.Window
        Me.pansubPage0.Controls.Add(Me.Page0DisktypeLabel)
        Me.pansubPage0.Controls.Add(Me.Page0TitleLabel)
        Me.pansubPage0.Controls.Add(Me.Page0DescriptionLabel)
        Me.pansubPage0.Controls.Add(Me.Page0DisktypeCmb)
        Me.pansubPage0.Location = New System.Drawing.Point(143, 0)
        Me.pansubPage0.Name = "pansubPage0"
        Me.pansubPage0.Size = New System.Drawing.Size(357, 302)
        Me.pansubPage0.TabIndex = 1
        '
        'Page0DisktypeLabel
        '
        Me.Page0DisktypeLabel.AutoSize = True
        Me.Page0DisktypeLabel.Location = New System.Drawing.Point(21, 250)
        Me.Page0DisktypeLabel.Name = "Page0DisktypeLabel"
        Me.Page0DisktypeLabel.Size = New System.Drawing.Size(54, 13)
        Me.Page0DisktypeLabel.TabIndex = 6
        Me.Page0DisktypeLabel.Text = "Disk type:"
        '
        'Page0DescriptionLabel
        '
        Me.Page0DescriptionLabel.AutoSize = True
        Me.Page0DescriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Page0DescriptionLabel.Location = New System.Drawing.Point(24, 52)
        Me.Page0DescriptionLabel.Name = "Page0DescriptionLabel"
        Me.Page0DescriptionLabel.Size = New System.Drawing.Size(298, 182)
        Me.Page0DescriptionLabel.TabIndex = 1
        Me.Page0DescriptionLabel.Text = resources.GetString("Page0DescriptionLabel.Text")
        '
        'Page0DisktypeCmb
        '
        Me.Page0DisktypeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Page0DisktypeCmb.FormattingEnabled = True
        Me.Page0DisktypeCmb.Items.AddRange(New Object() {"Fixed disk drive", "Removable blank 1.44 MB diskette", "Removable System 7.0 (68k) 1.44 MB diskette", "Removable System 8.5 (PPC) 1.44 MB diskette"})
        Me.Page0DisktypeCmb.Location = New System.Drawing.Point(81, 247)
        Me.Page0DisktypeCmb.Name = "Page0DisktypeCmb"
        Me.Page0DisktypeCmb.Size = New System.Drawing.Size(224, 21)
        Me.Page0DisktypeCmb.TabIndex = 5
        '
        'panPages
        '
        Me.panPages.Controls.Add(Me.pansubPage0)
        Me.panPages.Controls.Add(Me.pansubPage1)
        Me.panPages.Controls.Add(Me.pansubWizardPic)
        Me.panPages.Dock = System.Windows.Forms.DockStyle.Top
        Me.panPages.Location = New System.Drawing.Point(0, 0)
        Me.panPages.Name = "panPages"
        Me.panPages.Size = New System.Drawing.Size(494, 302)
        Me.panPages.TabIndex = 2
        '
        'SaveFile
        '
        Me.SaveFile.Filter = "Disk Image File (*.dsk)|*.dsk|RAW disk file (*.img)|*.img|All files (*.*)|*.*"
        '
        'frmDisk
        '
        Me.AcceptButton = Me.cmdNext
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(494, 344)
        Me.ControlBox = False
        Me.Controls.Add(Me.panPages)
        Me.Controls.Add(Me.grpControls)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmDisk"
        Me.Text = "Create a new disk"
        Me.grpControls.ResumeLayout(False)
        CType(Me.Page1DiskNewSizeNumUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pansubPage1.ResumeLayout(False)
        Me.pansubPage1.PerformLayout()
        Me.pansubPage0.ResumeLayout(False)
        Me.pansubPage0.PerformLayout()
        Me.panPages.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Page1DiskNewSizeLabel As System.Windows.Forms.Label
    Friend WithEvents grpControls As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents Page1DiskNewSizeNumUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents Page1DiskLocTxt As System.Windows.Forms.TextBox
    Friend WithEvents pansubPage1 As System.Windows.Forms.Panel
    Friend WithEvents Page1DiskLocBrowseBtn As System.Windows.Forms.Button
    Friend WithEvents Page1DescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents Page1TitleLabel As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pansubWizardPic As System.Windows.Forms.Panel
    Friend WithEvents Page0TitleLabel As System.Windows.Forms.Label
    Friend WithEvents pansubPage0 As System.Windows.Forms.Panel
    Friend WithEvents Page0DisktypeCmb As System.Windows.Forms.ComboBox
    Friend WithEvents panPages As System.Windows.Forms.Panel
    Friend WithEvents SaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Page0DescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents Page0DisktypeLabel As System.Windows.Forms.Label
    Friend WithEvents Page1DiskLocLabel As System.Windows.Forms.Label
End Class
