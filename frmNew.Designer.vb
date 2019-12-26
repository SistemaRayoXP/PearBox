<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNew))
        Me.grpControls = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.panPages = New System.Windows.Forms.Panel()
        Me.pansubPage0 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Page0TitleLabel = New System.Windows.Forms.Label()
        Me.Page0DescriptionLabel = New System.Windows.Forms.Label()
        Me.Page0NameLabel = New System.Windows.Forms.Label()
        Me.Page0NameText = New System.Windows.Forms.TextBox()
        Me.Page0FamilyContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.Page0FamilyLabel = New System.Windows.Forms.Label()
        Me.Page0FamilyCmb = New System.Windows.Forms.ComboBox()
        Me.Page0VersionLabel = New System.Windows.Forms.Label()
        Me.Page0VersionCmb = New System.Windows.Forms.ComboBox()
        Me.Page0OSPic = New System.Windows.Forms.PictureBox()
        Me.pansubPage1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Page1TitleLabel = New System.Windows.Forms.Label()
        Me.Page1DescriptionLabel = New System.Windows.Forms.Label()
        Me.Page1MemoryRecLabel = New System.Windows.Forms.Label()
        Me.Page1MemorySldr = New System.Windows.Forms.TrackBar()
        Me.Page1MemoryNumUD = New System.Windows.Forms.NumericUpDown()
        Me.Page1MemoryLabel = New System.Windows.Forms.Label()
        Me.pansubPage2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Page2TitleLabel = New System.Windows.Forms.Label()
        Me.Page2DescriptionLabel = New System.Windows.Forms.Label()
        Me.Page2DiskLocTxt = New System.Windows.Forms.TextBox()
        Me.Page2DiskLocBrowseBtn = New System.Windows.Forms.Button()
        Me.Page2DiskNewSizeLabel = New System.Windows.Forms.Label()
        Me.Page2DiskNewSizeNumUD = New System.Windows.Forms.NumericUpDown()
        Me.Page2NewRadio = New System.Windows.Forms.RadioButton()
        Me.Page2NoneRadio = New System.Windows.Forms.RadioButton()
        Me.Page2ExistRadio = New System.Windows.Forms.RadioButton()
        Me.pansubWizardPic = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.grpControls.SuspendLayout()
        Me.panPages.SuspendLayout()
        Me.pansubPage0.SuspendLayout()
        Me.Page0FamilyContainer.SuspendLayout()
        CType(Me.Page0OSPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pansubPage1.SuspendLayout()
        CType(Me.Page1MemorySldr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Page1MemoryNumUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pansubPage2.SuspendLayout()
        CType(Me.Page2DiskNewSizeNumUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpControls
        '
        Me.grpControls.Controls.Add(Me.cmdCancel)
        Me.grpControls.Controls.Add(Me.cmdNext)
        Me.grpControls.Controls.Add(Me.cmdBack)
        Me.grpControls.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpControls.Location = New System.Drawing.Point(0, 297)
        Me.grpControls.Name = "grpControls"
        Me.grpControls.Size = New System.Drawing.Size(500, 53)
        Me.grpControls.TabIndex = 0
        Me.grpControls.TabStop = False
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(413, 19)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Enabled = False
        Me.cmdNext.Location = New System.Drawing.Point(332, 19)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(75, 23)
        Me.cmdNext.TabIndex = 1
        Me.cmdNext.Text = "Next >"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Enabled = False
        Me.cmdBack.Location = New System.Drawing.Point(256, 19)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(75, 23)
        Me.cmdBack.TabIndex = 0
        Me.cmdBack.Text = "< Back"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'panPages
        '
        Me.panPages.Controls.Add(Me.pansubPage0)
        Me.panPages.Controls.Add(Me.pansubPage1)
        Me.panPages.Controls.Add(Me.pansubPage2)
        Me.panPages.Controls.Add(Me.pansubWizardPic)
        Me.panPages.Dock = System.Windows.Forms.DockStyle.Top
        Me.panPages.Location = New System.Drawing.Point(0, 0)
        Me.panPages.Name = "panPages"
        Me.panPages.Size = New System.Drawing.Size(500, 302)
        Me.panPages.TabIndex = 0
        '
        'pansubPage0
        '
        Me.pansubPage0.BackColor = System.Drawing.SystemColors.Window
        Me.pansubPage0.Controls.Add(Me.Page0TitleLabel)
        Me.pansubPage0.Controls.Add(Me.Page0DescriptionLabel)
        Me.pansubPage0.Controls.Add(Me.Page0NameLabel)
        Me.pansubPage0.Controls.Add(Me.Page0NameText)
        Me.pansubPage0.Controls.Add(Me.Page0FamilyContainer)
        Me.pansubPage0.Controls.Add(Me.Page0OSPic)
        Me.pansubPage0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pansubPage0.Location = New System.Drawing.Point(143, 0)
        Me.pansubPage0.Name = "pansubPage0"
        Me.pansubPage0.Padding = New System.Windows.Forms.Padding(20)
        Me.pansubPage0.Size = New System.Drawing.Size(357, 302)
        Me.pansubPage0.TabIndex = 2
        '
        'Page0TitleLabel
        '
        Me.Page0TitleLabel.AutoSize = True
        Me.pansubPage0.SetFlowBreak(Me.Page0TitleLabel, True)
        Me.Page0TitleLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Page0TitleLabel.Location = New System.Drawing.Point(27, 26)
        Me.Page0TitleLabel.Margin = New System.Windows.Forms.Padding(7, 6, 6, 6)
        Me.Page0TitleLabel.Name = "Page0TitleLabel"
        Me.Page0TitleLabel.Size = New System.Drawing.Size(237, 19)
        Me.Page0TitleLabel.TabIndex = 3
        Me.Page0TitleLabel.Text = "Name and operating system"
        '
        'Page0DescriptionLabel
        '
        Me.pansubPage0.SetFlowBreak(Me.Page0DescriptionLabel, True)
        Me.Page0DescriptionLabel.Location = New System.Drawing.Point(29, 57)
        Me.Page0DescriptionLabel.Margin = New System.Windows.Forms.Padding(9, 6, 6, 6)
        Me.Page0DescriptionLabel.Name = "Page0DescriptionLabel"
        Me.Page0DescriptionLabel.Size = New System.Drawing.Size(286, 109)
        Me.Page0DescriptionLabel.TabIndex = 4
        Me.Page0DescriptionLabel.Text = resources.GetString("Page0DescriptionLabel.Text")
        '
        'Page0NameLabel
        '
        Me.Page0NameLabel.Location = New System.Drawing.Point(29, 178)
        Me.Page0NameLabel.Margin = New System.Windows.Forms.Padding(9, 6, 6, 6)
        Me.Page0NameLabel.Name = "Page0NameLabel"
        Me.Page0NameLabel.Size = New System.Drawing.Size(50, 13)
        Me.Page0NameLabel.TabIndex = 5
        Me.Page0NameLabel.Text = "Name:"
        '
        'Page0NameText
        '
        Me.pansubPage0.SetFlowBreak(Me.Page0NameText, True)
        Me.Page0NameText.Location = New System.Drawing.Point(88, 175)
        Me.Page0NameText.Name = "Page0NameText"
        Me.Page0NameText.Size = New System.Drawing.Size(227, 21)
        Me.Page0NameText.TabIndex = 6
        '
        'Page0FamilyContainer
        '
        Me.Page0FamilyContainer.Controls.Add(Me.Page0FamilyLabel)
        Me.Page0FamilyContainer.Controls.Add(Me.Page0FamilyCmb)
        Me.Page0FamilyContainer.Controls.Add(Me.Page0VersionLabel)
        Me.Page0FamilyContainer.Controls.Add(Me.Page0VersionCmb)
        Me.Page0FamilyContainer.Location = New System.Drawing.Point(23, 202)
        Me.Page0FamilyContainer.Name = "Page0FamilyContainer"
        Me.Page0FamilyContainer.Size = New System.Drawing.Size(236, 66)
        Me.Page0FamilyContainer.TabIndex = 7
        '
        'Page0FamilyLabel
        '
        Me.Page0FamilyLabel.Location = New System.Drawing.Point(6, 6)
        Me.Page0FamilyLabel.Margin = New System.Windows.Forms.Padding(6)
        Me.Page0FamilyLabel.Name = "Page0FamilyLabel"
        Me.Page0FamilyLabel.Size = New System.Drawing.Size(50, 13)
        Me.Page0FamilyLabel.TabIndex = 8
        Me.Page0FamilyLabel.Text = "Family:"
        '
        'Page0FamilyCmb
        '
        Me.Page0FamilyCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Page0FamilyContainer.SetFlowBreak(Me.Page0FamilyCmb, True)
        Me.Page0FamilyCmb.FormattingEnabled = True
        Me.Page0FamilyCmb.Items.AddRange(New Object() {"Mac OS X", "Linux", "Other"})
        Me.Page0FamilyCmb.Location = New System.Drawing.Point(65, 3)
        Me.Page0FamilyCmb.Name = "Page0FamilyCmb"
        Me.Page0FamilyCmb.Size = New System.Drawing.Size(168, 21)
        Me.Page0FamilyCmb.TabIndex = 9
        '
        'Page0VersionLabel
        '
        Me.Page0VersionLabel.Location = New System.Drawing.Point(6, 33)
        Me.Page0VersionLabel.Margin = New System.Windows.Forms.Padding(6)
        Me.Page0VersionLabel.Name = "Page0VersionLabel"
        Me.Page0VersionLabel.Size = New System.Drawing.Size(50, 13)
        Me.Page0VersionLabel.TabIndex = 10
        Me.Page0VersionLabel.Text = "Version:"
        '
        'Page0VersionCmb
        '
        Me.Page0VersionCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Page0VersionCmb.FormattingEnabled = True
        Me.Page0VersionCmb.Location = New System.Drawing.Point(65, 30)
        Me.Page0VersionCmb.Name = "Page0VersionCmb"
        Me.Page0VersionCmb.Size = New System.Drawing.Size(168, 21)
        Me.Page0VersionCmb.TabIndex = 11
        '
        'Page0OSPic
        '
        Me.Page0OSPic.Location = New System.Drawing.Point(265, 202)
        Me.Page0OSPic.Name = "Page0OSPic"
        Me.Page0OSPic.Size = New System.Drawing.Size(50, 50)
        Me.Page0OSPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Page0OSPic.TabIndex = 17
        Me.Page0OSPic.TabStop = False
        '
        'pansubPage1
        '
        Me.pansubPage1.BackColor = System.Drawing.SystemColors.Window
        Me.pansubPage1.Controls.Add(Me.Page1TitleLabel)
        Me.pansubPage1.Controls.Add(Me.Page1DescriptionLabel)
        Me.pansubPage1.Controls.Add(Me.Page1MemoryRecLabel)
        Me.pansubPage1.Controls.Add(Me.Page1MemorySldr)
        Me.pansubPage1.Controls.Add(Me.Page1MemoryNumUD)
        Me.pansubPage1.Controls.Add(Me.Page1MemoryLabel)
        Me.pansubPage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pansubPage1.Location = New System.Drawing.Point(143, 0)
        Me.pansubPage1.Name = "pansubPage1"
        Me.pansubPage1.Padding = New System.Windows.Forms.Padding(20)
        Me.pansubPage1.Size = New System.Drawing.Size(357, 302)
        Me.pansubPage1.TabIndex = 10
        Me.pansubPage1.Visible = False
        '
        'Page1TitleLabel
        '
        Me.Page1TitleLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Page1TitleLabel.Location = New System.Drawing.Point(26, 26)
        Me.Page1TitleLabel.Margin = New System.Windows.Forms.Padding(6)
        Me.Page1TitleLabel.Name = "Page1TitleLabel"
        Me.Page1TitleLabel.Size = New System.Drawing.Size(252, 19)
        Me.Page1TitleLabel.TabIndex = 12
        Me.Page1TitleLabel.Text = "Memory"
        '
        'Page1DescriptionLabel
        '
        Me.Page1DescriptionLabel.Location = New System.Drawing.Point(29, 57)
        Me.Page1DescriptionLabel.Margin = New System.Windows.Forms.Padding(9, 6, 6, 6)
        Me.Page1DescriptionLabel.Name = "Page1DescriptionLabel"
        Me.Page1DescriptionLabel.Size = New System.Drawing.Size(270, 78)
        Me.Page1DescriptionLabel.TabIndex = 13
        Me.Page1DescriptionLabel.Text = resources.GetString("Page1DescriptionLabel.Text")
        Me.ToolTip1.SetToolTip(Me.Page1DescriptionLabel, "If you want to run heavy applications or simply" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "want to do multitasking, it's re" & _
        "commended that" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you increase the memory dedicated for this Mac.")
        '
        'Page1MemoryRecLabel
        '
        Me.Page1MemoryRecLabel.Location = New System.Drawing.Point(29, 147)
        Me.Page1MemoryRecLabel.Margin = New System.Windows.Forms.Padding(9, 6, 6, 6)
        Me.Page1MemoryRecLabel.Name = "Page1MemoryRecLabel"
        Me.Page1MemoryRecLabel.Size = New System.Drawing.Size(270, 13)
        Me.Page1MemoryRecLabel.TabIndex = 14
        Me.Page1MemoryRecLabel.Text = "The recommended memory size is %s MB."
        '
        'Page1MemorySldr
        '
        Me.Page1MemorySldr.Location = New System.Drawing.Point(23, 169)
        Me.Page1MemorySldr.Name = "Page1MemorySldr"
        Me.Page1MemorySldr.Size = New System.Drawing.Size(191, 45)
        Me.Page1MemorySldr.TabIndex = 15
        '
        'Page1MemoryNumUD
        '
        Me.Page1MemoryNumUD.Location = New System.Drawing.Point(220, 169)
        Me.Page1MemoryNumUD.Name = "Page1MemoryNumUD"
        Me.Page1MemoryNumUD.Size = New System.Drawing.Size(58, 21)
        Me.Page1MemoryNumUD.TabIndex = 16
        Me.Page1MemoryNumUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Page1MemoryNumUD.ThousandsSeparator = True
        '
        'Page1MemoryLabel
        '
        Me.Page1MemoryLabel.Location = New System.Drawing.Point(281, 172)
        Me.Page1MemoryLabel.Margin = New System.Windows.Forms.Padding(0, 6, 6, 6)
        Me.Page1MemoryLabel.Name = "Page1MemoryLabel"
        Me.Page1MemoryLabel.Size = New System.Drawing.Size(21, 13)
        Me.Page1MemoryLabel.TabIndex = 17
        Me.Page1MemoryLabel.Text = "MB"
        '
        'pansubPage2
        '
        Me.pansubPage2.BackColor = System.Drawing.SystemColors.Window
        Me.pansubPage2.Controls.Add(Me.Page2TitleLabel)
        Me.pansubPage2.Controls.Add(Me.Page2DescriptionLabel)
        Me.pansubPage2.Controls.Add(Me.Page2DiskLocTxt)
        Me.pansubPage2.Controls.Add(Me.Page2DiskLocBrowseBtn)
        Me.pansubPage2.Controls.Add(Me.Page2DiskNewSizeLabel)
        Me.pansubPage2.Controls.Add(Me.Page2DiskNewSizeNumUD)
        Me.pansubPage2.Controls.Add(Me.Page2NewRadio)
        Me.pansubPage2.Controls.Add(Me.Page2NoneRadio)
        Me.pansubPage2.Controls.Add(Me.Page2ExistRadio)
        Me.pansubPage2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pansubPage2.Location = New System.Drawing.Point(143, 0)
        Me.pansubPage2.Name = "pansubPage2"
        Me.pansubPage2.Padding = New System.Windows.Forms.Padding(20, 20, 16, 20)
        Me.pansubPage2.Size = New System.Drawing.Size(357, 302)
        Me.pansubPage2.TabIndex = 9
        Me.pansubPage2.Visible = False
        '
        'Page2TitleLabel
        '
        Me.Page2TitleLabel.AutoSize = True
        Me.pansubPage2.SetFlowBreak(Me.Page2TitleLabel, True)
        Me.Page2TitleLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Page2TitleLabel.Location = New System.Drawing.Point(29, 26)
        Me.Page2TitleLabel.Margin = New System.Windows.Forms.Padding(9, 6, 6, 6)
        Me.Page2TitleLabel.Name = "Page2TitleLabel"
        Me.Page2TitleLabel.Size = New System.Drawing.Size(73, 19)
        Me.Page2TitleLabel.TabIndex = 18
        Me.Page2TitleLabel.Text = "Storage"
        '
        'Page2DescriptionLabel
        '
        Me.Page2DescriptionLabel.AutoSize = True
        Me.pansubPage2.SetFlowBreak(Me.Page2DescriptionLabel, True)
        Me.Page2DescriptionLabel.Location = New System.Drawing.Point(29, 57)
        Me.Page2DescriptionLabel.Margin = New System.Windows.Forms.Padding(9, 6, 0, 6)
        Me.Page2DescriptionLabel.Name = "Page2DescriptionLabel"
        Me.Page2DescriptionLabel.Size = New System.Drawing.Size(311, 104)
        Me.Page2DescriptionLabel.TabIndex = 19
        Me.Page2DescriptionLabel.Text = resources.GetString("Page2DescriptionLabel.Text")
        '
        'Page2DiskLocTxt
        '
        Me.Page2DiskLocTxt.Location = New System.Drawing.Point(32, 170)
        Me.Page2DiskLocTxt.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.Page2DiskLocTxt.Name = "Page2DiskLocTxt"
        Me.Page2DiskLocTxt.Size = New System.Drawing.Size(210, 21)
        Me.Page2DiskLocTxt.TabIndex = 20
        '
        'Page2DiskLocBrowseBtn
        '
        Me.pansubPage2.SetFlowBreak(Me.Page2DiskLocBrowseBtn, True)
        Me.Page2DiskLocBrowseBtn.Location = New System.Drawing.Point(248, 169)
        Me.Page2DiskLocBrowseBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.Page2DiskLocBrowseBtn.Name = "Page2DiskLocBrowseBtn"
        Me.Page2DiskLocBrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.Page2DiskLocBrowseBtn.TabIndex = 21
        Me.Page2DiskLocBrowseBtn.Text = "Browse..."
        Me.Page2DiskLocBrowseBtn.UseVisualStyleBackColor = True
        '
        'Page2DiskNewSizeLabel
        '
        Me.Page2DiskNewSizeLabel.AutoSize = True
        Me.Page2DiskNewSizeLabel.Location = New System.Drawing.Point(185, 201)
        Me.Page2DiskNewSizeLabel.Margin = New System.Windows.Forms.Padding(165, 6, 6, 6)
        Me.Page2DiskNewSizeLabel.Name = "Page2DiskNewSizeLabel"
        Me.Page2DiskNewSizeLabel.Size = New System.Drawing.Size(55, 13)
        Me.Page2DiskNewSizeLabel.TabIndex = 22
        Me.Page2DiskNewSizeLabel.Text = "Size (MB):"
        Me.Page2DiskNewSizeLabel.Visible = False
        '
        'Page2DiskNewSizeNumUD
        '
        Me.pansubPage2.SetFlowBreak(Me.Page2DiskNewSizeNumUD, True)
        Me.Page2DiskNewSizeNumUD.Location = New System.Drawing.Point(249, 198)
        Me.Page2DiskNewSizeNumUD.Maximum = New Decimal(New Integer() {524288, 0, 0, 0})
        Me.Page2DiskNewSizeNumUD.Name = "Page2DiskNewSizeNumUD"
        Me.Page2DiskNewSizeNumUD.Size = New System.Drawing.Size(74, 21)
        Me.Page2DiskNewSizeNumUD.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.Page2DiskNewSizeNumUD, "The bigger the disk, the more time it will take to create")
        Me.Page2DiskNewSizeNumUD.Visible = False
        '
        'Page2NewRadio
        '
        Me.Page2NewRadio.AutoSize = True
        Me.Page2NewRadio.Checked = True
        Me.Page2NewRadio.Location = New System.Drawing.Point(32, 225)
        Me.Page2NewRadio.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.Page2NewRadio.Name = "Page2NewRadio"
        Me.Page2NewRadio.Size = New System.Drawing.Size(173, 17)
        Me.Page2NewRadio.TabIndex = 24
        Me.Page2NewRadio.TabStop = True
        Me.Page2NewRadio.Text = "Create a virtual hard disk now."
        Me.Page2NewRadio.UseVisualStyleBackColor = True
        '
        'Page2NoneRadio
        '
        Me.Page2NoneRadio.AutoSize = True
        Me.Page2NoneRadio.Location = New System.Drawing.Point(32, 248)
        Me.Page2NoneRadio.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.Page2NoneRadio.Name = "Page2NoneRadio"
        Me.Page2NoneRadio.Size = New System.Drawing.Size(185, 17)
        Me.Page2NoneRadio.TabIndex = 25
        Me.Page2NoneRadio.Text = "Do not add a hard disk right now."
        Me.Page2NoneRadio.UseVisualStyleBackColor = True
        '
        'Page2ExistRadio
        '
        Me.Page2ExistRadio.AutoSize = True
        Me.Page2ExistRadio.Location = New System.Drawing.Point(32, 271)
        Me.Page2ExistRadio.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.Page2ExistRadio.Name = "Page2ExistRadio"
        Me.Page2ExistRadio.Size = New System.Drawing.Size(198, 17)
        Me.Page2ExistRadio.TabIndex = 26
        Me.Page2ExistRadio.Text = "Use an existing virtual hard disk file."
        Me.Page2ExistRadio.UseVisualStyleBackColor = True
        '
        'pansubWizardPic
        '
        Me.pansubWizardPic.BackgroundImage = Global.PearBox.My.Resources.Resources.WizardImage
        Me.pansubWizardPic.Dock = System.Windows.Forms.DockStyle.Left
        Me.pansubWizardPic.Location = New System.Drawing.Point(0, 0)
        Me.pansubWizardPic.Name = "pansubWizardPic"
        Me.pansubWizardPic.Size = New System.Drawing.Size(143, 302)
        Me.pansubWizardPic.TabIndex = 1
        '
        'OpenFile
        '
        Me.OpenFile.Filter = "Disk Image File (*.dsk)|*.dsk|RAW disk file (*.img)|*.img|All files (*.*)|*.*"
        '
        'SaveFile
        '
        Me.SaveFile.Filter = "Disk Image File (*.dsk)|*.dsk|RAW disk file (*.img)|*.img|All files (*.*)|*.*"
        '
        'frmNew
        '
        Me.AcceptButton = Me.cmdNext
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(500, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.panPages)
        Me.Controls.Add(Me.grpControls)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create new Mac"
        Me.grpControls.ResumeLayout(False)
        Me.panPages.ResumeLayout(False)
        Me.pansubPage0.ResumeLayout(False)
        Me.pansubPage0.PerformLayout()
        Me.Page0FamilyContainer.ResumeLayout(False)
        CType(Me.Page0OSPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pansubPage1.ResumeLayout(False)
        Me.pansubPage1.PerformLayout()
        CType(Me.Page1MemorySldr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Page1MemoryNumUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pansubPage2.ResumeLayout(False)
        Me.pansubPage2.PerformLayout()
        CType(Me.Page2DiskNewSizeNumUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpControls As System.Windows.Forms.GroupBox
    Friend WithEvents panPages As System.Windows.Forms.Panel
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents pansubWizardPic As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pansubPage0 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Page0TitleLabel As System.Windows.Forms.Label
    Friend WithEvents Page0DescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents Page0NameLabel As System.Windows.Forms.Label
    Friend WithEvents Page0NameText As System.Windows.Forms.TextBox
    Friend WithEvents Page0FamilyLabel As System.Windows.Forms.Label
    Friend WithEvents Page0FamilyCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Page0VersionLabel As System.Windows.Forms.Label
    Friend WithEvents Page0VersionCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Page0FamilyContainer As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Page0OSPic As System.Windows.Forms.PictureBox
    Friend WithEvents pansubPage1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Page1TitleLabel As System.Windows.Forms.Label
    Friend WithEvents Page1DescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents Page1MemoryRecLabel As System.Windows.Forms.Label
    Friend WithEvents Page1MemorySldr As System.Windows.Forms.TrackBar
    Friend WithEvents Page1MemoryNumUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents Page1MemoryLabel As System.Windows.Forms.Label
    Friend WithEvents pansubPage2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Page2TitleLabel As System.Windows.Forms.Label
    Friend WithEvents Page2DescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents Page2DiskLocTxt As System.Windows.Forms.TextBox
    Friend WithEvents Page2DiskLocBrowseBtn As System.Windows.Forms.Button
    Friend WithEvents Page2DiskNewSizeLabel As System.Windows.Forms.Label
    Friend WithEvents Page2DiskNewSizeNumUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents Page2NewRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Page2NoneRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Page2ExistRadio As System.Windows.Forms.RadioButton
End Class
