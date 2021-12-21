<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Name", 0, 0)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Graphics", 1, 1)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Disks", 2, 2)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Network", 3, 3)
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Miscellaneous", 4, 4)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Advanced", 5, 5)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.BitDepth = New System.Windows.Forms.ComboBox()
        Me.Resolution = New System.Windows.Forms.Label()
        Me.FullscreenCheck = New System.Windows.Forms.CheckBox()
        Me.Fullscreen = New System.Windows.Forms.Label()
        Me.Browser = New System.Windows.Forms.OpenFileDialog()
        Me.ToggleFullscreenKeyLabel = New System.Windows.Forms.Label()
        Me.ToggleFullscreenKey = New System.Windows.Forms.TextBox()
        Me.Redraw = New System.Windows.Forms.Label()
        Me.RedrawTime = New System.Windows.Forms.TextBox()
        Me.Frequency = New System.Windows.Forms.NumericUpDown()
        Me.SlaveLocBrowse = New System.Windows.Forms.Button()
        Me.SlaveDriveTypeLabel = New System.Windows.Forms.Label()
        Me.SlaveLocLabel = New System.Windows.Forms.Label()
        Me.SlaveLoc = New System.Windows.Forms.TextBox()
        Me.SlaveEnabled = New System.Windows.Forms.CheckBox()
        Me.SlaveDriveType = New System.Windows.Forms.ComboBox()
        Me.MasterLocBrowse = New System.Windows.Forms.Button()
        Me.MasterDriveTypeLabel = New System.Windows.Forms.Label()
        Me.MasterLocLabel = New System.Windows.Forms.Label()
        Me.MasterLoc = New System.Windows.Forms.TextBox()
        Me.MasterEnabled = New System.Windows.Forms.CheckBox()
        Me.MasterDriveType = New System.Windows.Forms.ComboBox()
        Me.SelectDrive = New System.Windows.Forms.FolderBrowserDialog()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.SettingsPicker = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GraphicSettings = New System.Windows.Forms.FlowLayoutPanel()
        Me.XCustomResolution = New System.Windows.Forms.ComboBox()
        Me.YCustomResolution = New System.Windows.Forms.ComboBox()
        Me.DisksSettings = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.NetworkSettings = New System.Windows.Forms.FlowLayoutPanel()
        Me.NetRTL8139 = New System.Windows.Forms.CheckBox()
        Me.Net8139MacLabel = New System.Windows.Forms.Label()
        Me.Mac18139 = New System.Windows.Forms.TextBox()
        Me.Mac28139 = New System.Windows.Forms.TextBox()
        Me.Mac38139 = New System.Windows.Forms.TextBox()
        Me.Mac48139 = New System.Windows.Forms.TextBox()
        Me.Mac58139 = New System.Windows.Forms.TextBox()
        Me.Mac68139 = New System.Windows.Forms.TextBox()
        Me.Net3c90x = New System.Windows.Forms.CheckBox()
        Me.Net3c90MacLabel = New System.Windows.Forms.Label()
        Me.Mac13c90 = New System.Windows.Forms.TextBox()
        Me.Mac23c90 = New System.Windows.Forms.TextBox()
        Me.Mac33c90 = New System.Windows.Forms.TextBox()
        Me.Mac43c90 = New System.Windows.Forms.TextBox()
        Me.Mac53c90 = New System.Windows.Forms.TextBox()
        Me.Mac63c90 = New System.Windows.Forms.TextBox()
        Me.AdvancedSettings = New System.Windows.Forms.FlowLayoutPanel()
        Me.BootMode = New System.Windows.Forms.Label()
        Me.BootAuto = New System.Windows.Forms.RadioButton()
        Me.BootSelect = New System.Windows.Forms.RadioButton()
        Me.BootForce = New System.Windows.Forms.RadioButton()
        Me.AdvancedWarning = New System.Windows.Forms.Label()
        Me.PROMFileLabel = New System.Windows.Forms.Label()
        Me.PROMFile = New System.Windows.Forms.TextBox()
        Me.PROMFileBrowse = New System.Windows.Forms.Button()
        Me.PROMBootPathLabel = New System.Windows.Forms.Label()
        Me.PROMBootPath = New System.Windows.Forms.TextBox()
        Me.PROMBootPathBrowse = New System.Windows.Forms.Button()
        Me.MachArgumentsLabel = New System.Windows.Forms.Label()
        Me.MachArguments = New System.Windows.Forms.TextBox()
        Me.BootArgumentsLabel = New System.Windows.Forms.Label()
        Me.BootArguments = New System.Windows.Forms.TextBox()
        Me.GraphicDriverLabel = New System.Windows.Forms.Label()
        Me.GraphicDriver = New System.Windows.Forms.TextBox()
        Me.GraphicDriverBrowse = New System.Windows.Forms.Button()
        Me.NVRAMFileLabel = New System.Windows.Forms.Label()
        Me.NVRAMFile = New System.Windows.Forms.TextBox()
        Me.NVRAMFileBrowse = New System.Windows.Forms.Button()
        Me.PageTableLabel = New System.Windows.Forms.Label()
        Me.PageTable = New System.Windows.Forms.TextBox()
        Me.NameSettings = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MiscellaneousSettings = New System.Windows.Forms.FlowLayoutPanel()
        Me.RAMLabel = New System.Windows.Forms.Label()
        Me.RAMContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.RAM = New System.Windows.Forms.TextBox()
        Me.MB = New System.Windows.Forms.Label()
        Me.EnableUSB = New System.Windows.Forms.CheckBox()
        Me.EnableSerialPort = New System.Windows.Forms.CheckBox()
        Me.ProcessorLabel = New System.Windows.Forms.Label()
        Me.PPCG3 = New System.Windows.Forms.RadioButton()
        Me.PPCG4 = New System.Windows.Forms.RadioButton()
        Me.ChangeCDKeyLabel = New System.Windows.Forms.Label()
        Me.ChangeCDKey = New System.Windows.Forms.TextBox()
        Me.MouseGrabKeyLabel = New System.Windows.Forms.Label()
        Me.MouseToggleKey = New System.Windows.Forms.TextBox()
        Me.ComposeDialogKeyLabel = New System.Windows.Forms.Label()
        Me.ComposeDialogKey = New System.Windows.Forms.TextBox()
        Me.SaveConfigFile = New System.Windows.Forms.SaveFileDialog()
        CType(Me.Frequency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GraphicSettings.SuspendLayout()
        Me.DisksSettings.SuspendLayout()
        Me.cmdContainer.SuspendLayout()
        Me.NetworkSettings.SuspendLayout()
        Me.AdvancedSettings.SuspendLayout()
        Me.NameSettings.SuspendLayout()
        Me.MiscellaneousSettings.SuspendLayout()
        Me.RAMContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOK
        '
        Me.cmdOK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.Location = New System.Drawing.Point(528, 5)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'BitDepth
        '
        Me.BitDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BitDepth.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BitDepth.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BitDepth.FormattingEnabled = True
        Me.BitDepth.Items.AddRange(New Object() {"15", "32"})
        Me.BitDepth.Location = New System.Drawing.Point(221, 13)
        Me.BitDepth.Name = "BitDepth"
        Me.BitDepth.Size = New System.Drawing.Size(35, 21)
        Me.BitDepth.TabIndex = 3
        '
        'Resolution
        '
        Me.Resolution.AutoSize = True
        Me.Resolution.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resolution.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Resolution.Location = New System.Drawing.Point(19, 16)
        Me.Resolution.Margin = New System.Windows.Forms.Padding(9, 6, 6, 9)
        Me.Resolution.Name = "Resolution"
        Me.Resolution.Size = New System.Drawing.Size(61, 13)
        Me.Resolution.TabIndex = 5
        Me.Resolution.Text = "Resolution:"
        '
        'FullscreenCheck
        '
        Me.FullscreenCheck.AutoSize = True
        Me.FullscreenCheck.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullscreenCheck.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FullscreenCheck.Location = New System.Drawing.Point(90, 44)
        Me.FullscreenCheck.Margin = New System.Windows.Forms.Padding(6)
        Me.FullscreenCheck.Name = "FullscreenCheck"
        Me.FullscreenCheck.Size = New System.Drawing.Size(146, 17)
        Me.FullscreenCheck.TabIndex = 7
        Me.FullscreenCheck.Text = "Start always in fullscreen"
        Me.FullscreenCheck.UseVisualStyleBackColor = True
        '
        'Fullscreen
        '
        Me.Fullscreen.AutoSize = True
        Me.Fullscreen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fullscreen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Fullscreen.Location = New System.Drawing.Point(19, 44)
        Me.Fullscreen.Margin = New System.Windows.Forms.Padding(9, 6, 6, 9)
        Me.Fullscreen.Name = "Fullscreen"
        Me.Fullscreen.Size = New System.Drawing.Size(59, 13)
        Me.Fullscreen.TabIndex = 8
        Me.Fullscreen.Text = "Fullscreen:"
        '
        'Browser
        '
        Me.Browser.Filter = "Disc images(*.iso)|*.iso|Disk images (*.img)|*.img|All files (*.*)|*.*"
        '
        'ToggleFullscreenKeyLabel
        '
        Me.ToggleFullscreenKeyLabel.AutoSize = True
        Me.ToggleFullscreenKeyLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToggleFullscreenKeyLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToggleFullscreenKeyLabel.Location = New System.Drawing.Point(251, 44)
        Me.ToggleFullscreenKeyLabel.Margin = New System.Windows.Forms.Padding(9, 6, 6, 9)
        Me.ToggleFullscreenKeyLabel.Name = "ToggleFullscreenKeyLabel"
        Me.ToggleFullscreenKeyLabel.Size = New System.Drawing.Size(112, 13)
        Me.ToggleFullscreenKeyLabel.TabIndex = 11
        Me.ToggleFullscreenKeyLabel.Text = "Toggle fullscreen key:"
        '
        'ToggleFullscreenKey
        '
        Me.GraphicSettings.SetFlowBreak(Me.ToggleFullscreenKey, True)
        Me.ToggleFullscreenKey.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToggleFullscreenKey.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToggleFullscreenKey.Location = New System.Drawing.Point(372, 41)
        Me.ToggleFullscreenKey.Name = "ToggleFullscreenKey"
        Me.ToggleFullscreenKey.Size = New System.Drawing.Size(69, 21)
        Me.ToggleFullscreenKey.TabIndex = 12
        Me.ToggleFullscreenKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Redraw
        '
        Me.Redraw.AutoSize = True
        Me.Redraw.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Redraw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Redraw.Location = New System.Drawing.Point(19, 73)
        Me.Redraw.Margin = New System.Windows.Forms.Padding(9, 6, 6, 9)
        Me.Redraw.Name = "Redraw"
        Me.Redraw.Size = New System.Drawing.Size(111, 13)
        Me.Redraw.TabIndex = 14
        Me.Redraw.Text = "Redraw interval (ms):"
        '
        'RedrawTime
        '
        Me.RedrawTime.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedrawTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RedrawTime.Location = New System.Drawing.Point(139, 70)
        Me.RedrawTime.Name = "RedrawTime"
        Me.RedrawTime.Size = New System.Drawing.Size(69, 21)
        Me.RedrawTime.TabIndex = 15
        Me.RedrawTime.TabStop = False
        '
        'Frequency
        '
        Me.GraphicSettings.SetFlowBreak(Me.Frequency, True)
        Me.Frequency.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frequency.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frequency.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Frequency.Location = New System.Drawing.Point(262, 13)
        Me.Frequency.Maximum = New Decimal(New Integer() {140, 0, 0, 0})
        Me.Frequency.Name = "Frequency"
        Me.Frequency.Size = New System.Drawing.Size(36, 21)
        Me.Frequency.TabIndex = 17
        Me.Frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Frequency.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'SlaveLocBrowse
        '
        Me.SlaveLocBrowse.Enabled = False
        Me.SlaveLocBrowse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlaveLocBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SlaveLocBrowse.Location = New System.Drawing.Point(351, 152)
        Me.SlaveLocBrowse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.SlaveLocBrowse.Name = "SlaveLocBrowse"
        Me.SlaveLocBrowse.Size = New System.Drawing.Size(32, 23)
        Me.SlaveLocBrowse.TabIndex = 30
        Me.SlaveLocBrowse.Text = "..."
        Me.SlaveLocBrowse.UseVisualStyleBackColor = True
        '
        'SlaveDriveTypeLabel
        '
        Me.SlaveDriveTypeLabel.Enabled = False
        Me.SlaveDriveTypeLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlaveDriveTypeLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SlaveDriveTypeLabel.Location = New System.Drawing.Point(10, 128)
        Me.SlaveDriveTypeLabel.Margin = New System.Windows.Forms.Padding(0, 6, 9, 9)
        Me.SlaveDriveTypeLabel.Name = "SlaveDriveTypeLabel"
        Me.SlaveDriveTypeLabel.Size = New System.Drawing.Size(65, 13)
        Me.SlaveDriveTypeLabel.TabIndex = 28
        Me.SlaveDriveTypeLabel.Text = "Drive type:"
        '
        'SlaveLocLabel
        '
        Me.SlaveLocLabel.Enabled = False
        Me.SlaveLocLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlaveLocLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SlaveLocLabel.Location = New System.Drawing.Point(10, 156)
        Me.SlaveLocLabel.Margin = New System.Windows.Forms.Padding(0, 6, 9, 9)
        Me.SlaveLocLabel.Name = "SlaveLocLabel"
        Me.SlaveLocLabel.Size = New System.Drawing.Size(65, 13)
        Me.SlaveLocLabel.TabIndex = 29
        Me.SlaveLocLabel.Text = "Location:"
        '
        'SlaveLoc
        '
        Me.SlaveLoc.Enabled = False
        Me.SlaveLoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlaveLoc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SlaveLoc.Location = New System.Drawing.Point(87, 153)
        Me.SlaveLoc.Name = "SlaveLoc"
        Me.SlaveLoc.Size = New System.Drawing.Size(258, 21)
        Me.SlaveLoc.TabIndex = 29
        '
        'SlaveEnabled
        '
        Me.SlaveEnabled.AutoSize = True
        Me.DisksSettings.SetFlowBreak(Me.SlaveEnabled, True)
        Me.SlaveEnabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlaveEnabled.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SlaveEnabled.Location = New System.Drawing.Point(13, 97)
        Me.SlaveEnabled.Name = "SlaveEnabled"
        Me.SlaveEnabled.Size = New System.Drawing.Size(115, 17)
        Me.SlaveEnabled.TabIndex = 27
        Me.SlaveEnabled.Text = "Enable Slave Drive"
        Me.SlaveEnabled.UseVisualStyleBackColor = True
        '
        'SlaveDriveType
        '
        Me.SlaveDriveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SlaveDriveType.Enabled = False
        Me.DisksSettings.SetFlowBreak(Me.SlaveDriveType, True)
        Me.SlaveDriveType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlaveDriveType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SlaveDriveType.FormattingEnabled = True
        Me.SlaveDriveType.Items.AddRange(New Object() {"Hard disk", "CD-ROM", "Physical drive"})
        Me.SlaveDriveType.Location = New System.Drawing.Point(87, 125)
        Me.SlaveDriveType.Name = "SlaveDriveType"
        Me.SlaveDriveType.Size = New System.Drawing.Size(121, 21)
        Me.SlaveDriveType.TabIndex = 28
        '
        'MasterLocBrowse
        '
        Me.MasterLocBrowse.Enabled = False
        Me.DisksSettings.SetFlowBreak(Me.MasterLocBrowse, True)
        Me.MasterLocBrowse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterLocBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MasterLocBrowse.Location = New System.Drawing.Point(351, 68)
        Me.MasterLocBrowse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.MasterLocBrowse.Name = "MasterLocBrowse"
        Me.MasterLocBrowse.Size = New System.Drawing.Size(32, 23)
        Me.MasterLocBrowse.TabIndex = 21
        Me.MasterLocBrowse.Text = "..."
        Me.MasterLocBrowse.UseVisualStyleBackColor = True
        '
        'MasterDriveTypeLabel
        '
        Me.MasterDriveTypeLabel.Enabled = False
        Me.MasterDriveTypeLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterDriveTypeLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MasterDriveTypeLabel.Location = New System.Drawing.Point(10, 44)
        Me.MasterDriveTypeLabel.Margin = New System.Windows.Forms.Padding(0, 6, 9, 9)
        Me.MasterDriveTypeLabel.Name = "MasterDriveTypeLabel"
        Me.MasterDriveTypeLabel.Size = New System.Drawing.Size(65, 13)
        Me.MasterDriveTypeLabel.TabIndex = 18
        Me.MasterDriveTypeLabel.Text = "Drive type:"
        '
        'MasterLocLabel
        '
        Me.MasterLocLabel.Enabled = False
        Me.MasterLocLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterLocLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MasterLocLabel.Location = New System.Drawing.Point(10, 72)
        Me.MasterLocLabel.Margin = New System.Windows.Forms.Padding(0, 6, 9, 9)
        Me.MasterLocLabel.Name = "MasterLocLabel"
        Me.MasterLocLabel.Size = New System.Drawing.Size(65, 13)
        Me.MasterLocLabel.TabIndex = 19
        Me.MasterLocLabel.Text = "Location:"
        '
        'MasterLoc
        '
        Me.MasterLoc.Enabled = False
        Me.MasterLoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterLoc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MasterLoc.Location = New System.Drawing.Point(87, 69)
        Me.MasterLoc.Name = "MasterLoc"
        Me.MasterLoc.Size = New System.Drawing.Size(258, 21)
        Me.MasterLoc.TabIndex = 20
        '
        'MasterEnabled
        '
        Me.MasterEnabled.AutoSize = True
        Me.DisksSettings.SetFlowBreak(Me.MasterEnabled, True)
        Me.MasterEnabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterEnabled.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MasterEnabled.Location = New System.Drawing.Point(13, 13)
        Me.MasterEnabled.Name = "MasterEnabled"
        Me.MasterEnabled.Size = New System.Drawing.Size(122, 17)
        Me.MasterEnabled.TabIndex = 18
        Me.MasterEnabled.Text = "Enable Master Drive"
        Me.MasterEnabled.UseVisualStyleBackColor = True
        '
        'MasterDriveType
        '
        Me.MasterDriveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MasterDriveType.Enabled = False
        Me.DisksSettings.SetFlowBreak(Me.MasterDriveType, True)
        Me.MasterDriveType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterDriveType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MasterDriveType.FormattingEnabled = True
        Me.MasterDriveType.Items.AddRange(New Object() {"Hard disk", "CD-ROM", "Physical drive"})
        Me.MasterDriveType.Location = New System.Drawing.Point(87, 41)
        Me.MasterDriveType.Name = "MasterDriveType"
        Me.MasterDriveType.Size = New System.Drawing.Size(121, 21)
        Me.MasterDriveType.TabIndex = 19
        Me.MasterDriveType.TabStop = False
        '
        'SelectDrive
        '
        Me.SelectDrive.Description = "Select a physical drive to use with PearPC"
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(609, 5)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 21
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'SettingsPicker
        '
        Me.SettingsPicker.Dock = System.Windows.Forms.DockStyle.Left
        Me.SettingsPicker.FullRowSelect = True
        Me.SettingsPicker.HideSelection = False
        Me.SettingsPicker.ImageIndex = 0
        Me.SettingsPicker.ImageList = Me.ImageList1
        Me.SettingsPicker.Location = New System.Drawing.Point(12, 12)
        Me.SettingsPicker.Name = "SettingsPicker"
        TreeNode1.ImageIndex = 0
        TreeNode1.Name = "Nodo0"
        TreeNode1.SelectedImageIndex = 0
        TreeNode1.Text = "Name"
        TreeNode2.ImageIndex = 1
        TreeNode2.Name = "Nodo1"
        TreeNode2.SelectedImageIndex = 1
        TreeNode2.Text = "Graphics"
        TreeNode3.ImageIndex = 2
        TreeNode3.Name = "Nodo2"
        TreeNode3.SelectedImageIndex = 2
        TreeNode3.Text = "Disks"
        TreeNode4.ImageIndex = 3
        TreeNode4.Name = "Nodo3"
        TreeNode4.SelectedImageIndex = 3
        TreeNode4.Text = "Network"
        TreeNode5.ImageIndex = 4
        TreeNode5.Name = "Nodo4"
        TreeNode5.SelectedImageIndex = 4
        TreeNode5.Text = "Miscellaneous"
        TreeNode6.ImageIndex = 5
        TreeNode6.Name = "Nodo5"
        TreeNode6.SelectedImageIndex = 5
        TreeNode6.Text = "Advanced"
        Me.SettingsPicker.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Me.SettingsPicker.SelectedImageIndex = 0
        Me.SettingsPicker.ShowLines = False
        Me.SettingsPicker.ShowPlusMinus = False
        Me.SettingsPicker.ShowRootLines = False
        Me.SettingsPicker.Size = New System.Drawing.Size(181, 372)
        Me.SettingsPicker.TabIndex = 22
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Image7.Image.png")
        Me.ImageList1.Images.SetKeyName(1, "Image5.Image.png")
        Me.ImageList1.Images.SetKeyName(2, "Image4.Image.png")
        Me.ImageList1.Images.SetKeyName(3, "Image6.Image.png")
        Me.ImageList1.Images.SetKeyName(4, "Image9.Image.png")
        Me.ImageList1.Images.SetKeyName(5, "Image3.Image.png")
        '
        'GraphicSettings
        '
        Me.GraphicSettings.BackColor = System.Drawing.SystemColors.Window
        Me.GraphicSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GraphicSettings.Controls.Add(Me.Resolution)
        Me.GraphicSettings.Controls.Add(Me.XCustomResolution)
        Me.GraphicSettings.Controls.Add(Me.YCustomResolution)
        Me.GraphicSettings.Controls.Add(Me.BitDepth)
        Me.GraphicSettings.Controls.Add(Me.Frequency)
        Me.GraphicSettings.Controls.Add(Me.Fullscreen)
        Me.GraphicSettings.Controls.Add(Me.FullscreenCheck)
        Me.GraphicSettings.Controls.Add(Me.ToggleFullscreenKeyLabel)
        Me.GraphicSettings.Controls.Add(Me.ToggleFullscreenKey)
        Me.GraphicSettings.Controls.Add(Me.Redraw)
        Me.GraphicSettings.Controls.Add(Me.RedrawTime)
        Me.GraphicSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GraphicSettings.Location = New System.Drawing.Point(193, 12)
        Me.GraphicSettings.Name = "GraphicSettings"
        Me.GraphicSettings.Padding = New System.Windows.Forms.Padding(10)
        Me.GraphicSettings.Size = New System.Drawing.Size(505, 372)
        Me.GraphicSettings.TabIndex = 22
        '
        'XCustomResolution
        '
        Me.XCustomResolution.FormattingEnabled = True
        Me.XCustomResolution.Items.AddRange(New Object() {"160", "192", "320", "270", "400", "360", "512", "480", "720", "600", "840", "720", "1024", "864", "1280", "1020", "1440", "1140", "1600", "1320", "1920", "1536", "2160"})
        Me.XCustomResolution.Location = New System.Drawing.Point(89, 13)
        Me.XCustomResolution.Name = "XCustomResolution"
        Me.XCustomResolution.Size = New System.Drawing.Size(60, 21)
        Me.XCustomResolution.TabIndex = 22
        '
        'YCustomResolution
        '
        Me.YCustomResolution.FormattingEnabled = True
        Me.YCustomResolution.Items.AddRange(New Object() {"120", "256", "240", "360", "300", "480", "384", "640", "540", "800", "630", "960", "768", "1152", "960", "1360", "1080", "1520", "1200", "1760", "1440", "2048", "1620"})
        Me.YCustomResolution.Location = New System.Drawing.Point(155, 13)
        Me.YCustomResolution.Name = "YCustomResolution"
        Me.YCustomResolution.Size = New System.Drawing.Size(60, 21)
        Me.YCustomResolution.TabIndex = 23
        '
        'DisksSettings
        '
        Me.DisksSettings.BackColor = System.Drawing.SystemColors.Window
        Me.DisksSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DisksSettings.Controls.Add(Me.MasterEnabled)
        Me.DisksSettings.Controls.Add(Me.MasterDriveTypeLabel)
        Me.DisksSettings.Controls.Add(Me.MasterDriveType)
        Me.DisksSettings.Controls.Add(Me.MasterLocLabel)
        Me.DisksSettings.Controls.Add(Me.MasterLoc)
        Me.DisksSettings.Controls.Add(Me.MasterLocBrowse)
        Me.DisksSettings.Controls.Add(Me.SlaveEnabled)
        Me.DisksSettings.Controls.Add(Me.SlaveDriveTypeLabel)
        Me.DisksSettings.Controls.Add(Me.SlaveDriveType)
        Me.DisksSettings.Controls.Add(Me.SlaveLocLabel)
        Me.DisksSettings.Controls.Add(Me.SlaveLoc)
        Me.DisksSettings.Controls.Add(Me.SlaveLocBrowse)
        Me.DisksSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DisksSettings.Location = New System.Drawing.Point(193, 12)
        Me.DisksSettings.Name = "DisksSettings"
        Me.DisksSettings.Padding = New System.Windows.Forms.Padding(10)
        Me.DisksSettings.Size = New System.Drawing.Size(505, 372)
        Me.DisksSettings.TabIndex = 31
        '
        'cmdContainer
        '
        Me.cmdContainer.Controls.Add(Me.cmdCancel)
        Me.cmdContainer.Controls.Add(Me.cmdOK)
        Me.cmdContainer.Controls.Add(Me.ProgressBar1)
        Me.cmdContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdContainer.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.cmdContainer.Location = New System.Drawing.Point(12, 384)
        Me.cmdContainer.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.cmdContainer.Name = "cmdContainer"
        Me.cmdContainer.Padding = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.cmdContainer.Size = New System.Drawing.Size(686, 32)
        Me.cmdContainer.TabIndex = 22
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 5)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 3, 345, 3)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(177, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 4
        '
        'NetworkSettings
        '
        Me.NetworkSettings.BackColor = System.Drawing.SystemColors.Window
        Me.NetworkSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NetworkSettings.Controls.Add(Me.NetRTL8139)
        Me.NetworkSettings.Controls.Add(Me.Net8139MacLabel)
        Me.NetworkSettings.Controls.Add(Me.Mac18139)
        Me.NetworkSettings.Controls.Add(Me.Mac28139)
        Me.NetworkSettings.Controls.Add(Me.Mac38139)
        Me.NetworkSettings.Controls.Add(Me.Mac48139)
        Me.NetworkSettings.Controls.Add(Me.Mac58139)
        Me.NetworkSettings.Controls.Add(Me.Mac68139)
        Me.NetworkSettings.Controls.Add(Me.Net3c90x)
        Me.NetworkSettings.Controls.Add(Me.Net3c90MacLabel)
        Me.NetworkSettings.Controls.Add(Me.Mac13c90)
        Me.NetworkSettings.Controls.Add(Me.Mac23c90)
        Me.NetworkSettings.Controls.Add(Me.Mac33c90)
        Me.NetworkSettings.Controls.Add(Me.Mac43c90)
        Me.NetworkSettings.Controls.Add(Me.Mac53c90)
        Me.NetworkSettings.Controls.Add(Me.Mac63c90)
        Me.NetworkSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NetworkSettings.Location = New System.Drawing.Point(193, 12)
        Me.NetworkSettings.Name = "NetworkSettings"
        Me.NetworkSettings.Padding = New System.Windows.Forms.Padding(10)
        Me.NetworkSettings.Size = New System.Drawing.Size(505, 372)
        Me.NetworkSettings.TabIndex = 21
        '
        'NetRTL8139
        '
        Me.NetRTL8139.AutoSize = True
        Me.NetworkSettings.SetFlowBreak(Me.NetRTL8139, True)
        Me.NetRTL8139.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetRTL8139.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NetRTL8139.Location = New System.Drawing.Point(13, 13)
        Me.NetRTL8139.Name = "NetRTL8139"
        Me.NetRTL8139.Size = New System.Drawing.Size(137, 17)
        Me.NetRTL8139.TabIndex = 22
        Me.NetRTL8139.Text = "Network Card RTL8139"
        Me.NetRTL8139.UseVisualStyleBackColor = True
        '
        'Net8139MacLabel
        '
        Me.Net8139MacLabel.AutoSize = True
        Me.Net8139MacLabel.Enabled = False
        Me.Net8139MacLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Net8139MacLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net8139MacLabel.Location = New System.Drawing.Point(10, 44)
        Me.Net8139MacLabel.Margin = New System.Windows.Forms.Padding(0, 6, 6, 9)
        Me.Net8139MacLabel.Name = "Net8139MacLabel"
        Me.Net8139MacLabel.Size = New System.Drawing.Size(33, 13)
        Me.Net8139MacLabel.TabIndex = 36
        Me.Net8139MacLabel.Text = "MAC:"
        '
        'Mac18139
        '
        Me.Mac18139.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac18139.Enabled = False
        Me.Mac18139.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac18139.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac18139.Location = New System.Drawing.Point(52, 41)
        Me.Mac18139.MaxLength = 2
        Me.Mac18139.Name = "Mac18139"
        Me.Mac18139.Size = New System.Drawing.Size(27, 21)
        Me.Mac18139.TabIndex = 29
        '
        'Mac28139
        '
        Me.Mac28139.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac28139.Enabled = False
        Me.Mac28139.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac28139.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac28139.Location = New System.Drawing.Point(85, 41)
        Me.Mac28139.MaxLength = 2
        Me.Mac28139.Name = "Mac28139"
        Me.Mac28139.Size = New System.Drawing.Size(27, 21)
        Me.Mac28139.TabIndex = 30
        '
        'Mac38139
        '
        Me.Mac38139.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac38139.Enabled = False
        Me.Mac38139.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac38139.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac38139.Location = New System.Drawing.Point(118, 41)
        Me.Mac38139.MaxLength = 2
        Me.Mac38139.Name = "Mac38139"
        Me.Mac38139.Size = New System.Drawing.Size(27, 21)
        Me.Mac38139.TabIndex = 31
        '
        'Mac48139
        '
        Me.Mac48139.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac48139.Enabled = False
        Me.Mac48139.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac48139.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac48139.Location = New System.Drawing.Point(151, 41)
        Me.Mac48139.MaxLength = 2
        Me.Mac48139.Name = "Mac48139"
        Me.Mac48139.Size = New System.Drawing.Size(27, 21)
        Me.Mac48139.TabIndex = 32
        '
        'Mac58139
        '
        Me.Mac58139.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac58139.Enabled = False
        Me.Mac58139.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac58139.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac58139.Location = New System.Drawing.Point(184, 41)
        Me.Mac58139.MaxLength = 2
        Me.Mac58139.Name = "Mac58139"
        Me.Mac58139.Size = New System.Drawing.Size(27, 21)
        Me.Mac58139.TabIndex = 33
        '
        'Mac68139
        '
        Me.Mac68139.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac68139.Enabled = False
        Me.NetworkSettings.SetFlowBreak(Me.Mac68139, True)
        Me.Mac68139.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac68139.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac68139.Location = New System.Drawing.Point(217, 41)
        Me.Mac68139.MaxLength = 2
        Me.Mac68139.Name = "Mac68139"
        Me.Mac68139.Size = New System.Drawing.Size(27, 21)
        Me.Mac68139.TabIndex = 34
        '
        'Net3c90x
        '
        Me.Net3c90x.AutoSize = True
        Me.NetworkSettings.SetFlowBreak(Me.Net3c90x, True)
        Me.Net3c90x.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Net3c90x.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net3c90x.Location = New System.Drawing.Point(13, 69)
        Me.Net3c90x.Name = "Net3c90x"
        Me.Net3c90x.Size = New System.Drawing.Size(124, 17)
        Me.Net3c90x.TabIndex = 21
        Me.Net3c90x.Text = "Network Card 3c90x"
        Me.Net3c90x.UseVisualStyleBackColor = True
        '
        'Net3c90MacLabel
        '
        Me.Net3c90MacLabel.AutoSize = True
        Me.Net3c90MacLabel.Enabled = False
        Me.Net3c90MacLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Net3c90MacLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net3c90MacLabel.Location = New System.Drawing.Point(10, 100)
        Me.Net3c90MacLabel.Margin = New System.Windows.Forms.Padding(0, 6, 6, 9)
        Me.Net3c90MacLabel.Name = "Net3c90MacLabel"
        Me.Net3c90MacLabel.Size = New System.Drawing.Size(33, 13)
        Me.Net3c90MacLabel.TabIndex = 35
        Me.Net3c90MacLabel.Text = "MAC:"
        '
        'Mac13c90
        '
        Me.Mac13c90.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac13c90.Enabled = False
        Me.Mac13c90.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac13c90.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac13c90.Location = New System.Drawing.Point(52, 97)
        Me.Mac13c90.MaxLength = 2
        Me.Mac13c90.Name = "Mac13c90"
        Me.Mac13c90.Size = New System.Drawing.Size(27, 21)
        Me.Mac13c90.TabIndex = 23
        '
        'Mac23c90
        '
        Me.Mac23c90.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac23c90.Enabled = False
        Me.Mac23c90.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac23c90.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac23c90.Location = New System.Drawing.Point(85, 97)
        Me.Mac23c90.MaxLength = 2
        Me.Mac23c90.Name = "Mac23c90"
        Me.Mac23c90.Size = New System.Drawing.Size(27, 21)
        Me.Mac23c90.TabIndex = 24
        '
        'Mac33c90
        '
        Me.Mac33c90.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac33c90.Enabled = False
        Me.Mac33c90.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac33c90.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac33c90.Location = New System.Drawing.Point(118, 97)
        Me.Mac33c90.MaxLength = 2
        Me.Mac33c90.Name = "Mac33c90"
        Me.Mac33c90.Size = New System.Drawing.Size(27, 21)
        Me.Mac33c90.TabIndex = 25
        '
        'Mac43c90
        '
        Me.Mac43c90.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac43c90.Enabled = False
        Me.Mac43c90.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac43c90.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac43c90.Location = New System.Drawing.Point(151, 97)
        Me.Mac43c90.MaxLength = 2
        Me.Mac43c90.Name = "Mac43c90"
        Me.Mac43c90.Size = New System.Drawing.Size(27, 21)
        Me.Mac43c90.TabIndex = 26
        '
        'Mac53c90
        '
        Me.Mac53c90.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac53c90.Enabled = False
        Me.Mac53c90.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac53c90.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac53c90.Location = New System.Drawing.Point(184, 97)
        Me.Mac53c90.MaxLength = 2
        Me.Mac53c90.Name = "Mac53c90"
        Me.Mac53c90.Size = New System.Drawing.Size(27, 21)
        Me.Mac53c90.TabIndex = 27
        '
        'Mac63c90
        '
        Me.Mac63c90.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac63c90.Enabled = False
        Me.Mac63c90.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac63c90.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac63c90.Location = New System.Drawing.Point(217, 97)
        Me.Mac63c90.MaxLength = 2
        Me.Mac63c90.Name = "Mac63c90"
        Me.Mac63c90.Size = New System.Drawing.Size(27, 21)
        Me.Mac63c90.TabIndex = 28
        '
        'AdvancedSettings
        '
        Me.AdvancedSettings.BackColor = System.Drawing.SystemColors.Window
        Me.AdvancedSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AdvancedSettings.Controls.Add(Me.BootMode)
        Me.AdvancedSettings.Controls.Add(Me.BootAuto)
        Me.AdvancedSettings.Controls.Add(Me.BootSelect)
        Me.AdvancedSettings.Controls.Add(Me.BootForce)
        Me.AdvancedSettings.Controls.Add(Me.AdvancedWarning)
        Me.AdvancedSettings.Controls.Add(Me.PROMFileLabel)
        Me.AdvancedSettings.Controls.Add(Me.PROMFile)
        Me.AdvancedSettings.Controls.Add(Me.PROMFileBrowse)
        Me.AdvancedSettings.Controls.Add(Me.PROMBootPathLabel)
        Me.AdvancedSettings.Controls.Add(Me.PROMBootPath)
        Me.AdvancedSettings.Controls.Add(Me.PROMBootPathBrowse)
        Me.AdvancedSettings.Controls.Add(Me.MachArgumentsLabel)
        Me.AdvancedSettings.Controls.Add(Me.MachArguments)
        Me.AdvancedSettings.Controls.Add(Me.BootArgumentsLabel)
        Me.AdvancedSettings.Controls.Add(Me.BootArguments)
        Me.AdvancedSettings.Controls.Add(Me.GraphicDriverLabel)
        Me.AdvancedSettings.Controls.Add(Me.GraphicDriver)
        Me.AdvancedSettings.Controls.Add(Me.GraphicDriverBrowse)
        Me.AdvancedSettings.Controls.Add(Me.NVRAMFileLabel)
        Me.AdvancedSettings.Controls.Add(Me.NVRAMFile)
        Me.AdvancedSettings.Controls.Add(Me.NVRAMFileBrowse)
        Me.AdvancedSettings.Controls.Add(Me.PageTableLabel)
        Me.AdvancedSettings.Controls.Add(Me.PageTable)
        Me.AdvancedSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdvancedSettings.Location = New System.Drawing.Point(193, 12)
        Me.AdvancedSettings.Name = "AdvancedSettings"
        Me.AdvancedSettings.Padding = New System.Windows.Forms.Padding(10)
        Me.AdvancedSettings.Size = New System.Drawing.Size(505, 372)
        Me.AdvancedSettings.TabIndex = 32
        '
        'BootMode
        '
        Me.BootMode.AutoSize = True
        Me.BootMode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BootMode.Location = New System.Drawing.Point(19, 16)
        Me.BootMode.Margin = New System.Windows.Forms.Padding(9, 6, 6, 9)
        Me.BootMode.Name = "BootMode"
        Me.BootMode.Size = New System.Drawing.Size(59, 13)
        Me.BootMode.TabIndex = 28
        Me.BootMode.Text = "Boot Mode"
        '
        'BootAuto
        '
        Me.BootAuto.AutoSize = True
        Me.BootAuto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BootAuto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BootAuto.Location = New System.Drawing.Point(87, 13)
        Me.BootAuto.Name = "BootAuto"
        Me.BootAuto.Size = New System.Drawing.Size(48, 17)
        Me.BootAuto.TabIndex = 27
        Me.BootAuto.Text = "Auto"
        Me.BootAuto.UseVisualStyleBackColor = True
        '
        'BootSelect
        '
        Me.BootSelect.AutoSize = True
        Me.BootSelect.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BootSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BootSelect.Location = New System.Drawing.Point(141, 13)
        Me.BootSelect.Name = "BootSelect"
        Me.BootSelect.Size = New System.Drawing.Size(54, 17)
        Me.BootSelect.TabIndex = 26
        Me.BootSelect.Text = "Select"
        Me.BootSelect.UseVisualStyleBackColor = True
        '
        'BootForce
        '
        Me.BootForce.AutoSize = True
        Me.AdvancedSettings.SetFlowBreak(Me.BootForce, True)
        Me.BootForce.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BootForce.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BootForce.Location = New System.Drawing.Point(201, 13)
        Me.BootForce.Name = "BootForce"
        Me.BootForce.Size = New System.Drawing.Size(52, 17)
        Me.BootForce.TabIndex = 25
        Me.BootForce.Text = "Force"
        Me.BootForce.UseVisualStyleBackColor = True
        '
        'AdvancedWarning
        '
        Me.AdvancedWarning.AutoSize = True
        Me.AdvancedSettings.SetFlowBreak(Me.AdvancedWarning, True)
        Me.AdvancedWarning.ForeColor = System.Drawing.Color.Red
        Me.AdvancedWarning.Location = New System.Drawing.Point(19, 44)
        Me.AdvancedWarning.Margin = New System.Windows.Forms.Padding(9, 6, 6, 9)
        Me.AdvancedWarning.Name = "AdvancedWarning"
        Me.AdvancedWarning.Size = New System.Drawing.Size(256, 13)
        Me.AdvancedWarning.TabIndex = 33
        Me.AdvancedWarning.Text = "Warning! Only change if you know what you're doing"
        '
        'PROMFileLabel
        '
        Me.PROMFileLabel.Enabled = False
        Me.PROMFileLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROMFileLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PROMFileLabel.Location = New System.Drawing.Point(19, 72)
        Me.PROMFileLabel.Margin = New System.Windows.Forms.Padding(9, 6, 6, 9)
        Me.PROMFileLabel.Name = "PROMFileLabel"
        Me.PROMFileLabel.Size = New System.Drawing.Size(100, 13)
        Me.PROMFileLabel.TabIndex = 17
        Me.PROMFileLabel.Text = "PROM File:"
        '
        'PROMFile
        '
        Me.PROMFile.Enabled = False
        Me.PROMFile.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROMFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PROMFile.Location = New System.Drawing.Point(128, 69)
        Me.PROMFile.Name = "PROMFile"
        Me.PROMFile.Size = New System.Drawing.Size(313, 21)
        Me.PROMFile.TabIndex = 19
        '
        'PROMFileBrowse
        '
        Me.AdvancedSettings.SetFlowBreak(Me.PROMFileBrowse, True)
        Me.PROMFileBrowse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROMFileBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PROMFileBrowse.Location = New System.Drawing.Point(447, 68)
        Me.PROMFileBrowse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.PROMFileBrowse.Name = "PROMFileBrowse"
        Me.PROMFileBrowse.Size = New System.Drawing.Size(32, 23)
        Me.PROMFileBrowse.TabIndex = 35
        Me.PROMFileBrowse.Text = "..."
        Me.PROMFileBrowse.UseVisualStyleBackColor = True
        '
        'PROMBootPathLabel
        '
        Me.PROMBootPathLabel.Enabled = False
        Me.PROMBootPathLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROMBootPathLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PROMBootPathLabel.Location = New System.Drawing.Point(19, 100)
        Me.PROMBootPathLabel.Margin = New System.Windows.Forms.Padding(9, 6, 6, 9)
        Me.PROMBootPathLabel.Name = "PROMBootPathLabel"
        Me.PROMBootPathLabel.Size = New System.Drawing.Size(100, 13)
        Me.PROMBootPathLabel.TabIndex = 18
        Me.PROMBootPathLabel.Text = "PROM Boot Path:"
        '
        'PROMBootPath
        '
        Me.PROMBootPath.Enabled = False
        Me.PROMBootPath.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROMBootPath.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PROMBootPath.Location = New System.Drawing.Point(128, 97)
        Me.PROMBootPath.Name = "PROMBootPath"
        Me.PROMBootPath.Size = New System.Drawing.Size(313, 21)
        Me.PROMBootPath.TabIndex = 20
        '
        'PROMBootPathBrowse
        '
        Me.AdvancedSettings.SetFlowBreak(Me.PROMBootPathBrowse, True)
        Me.PROMBootPathBrowse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROMBootPathBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PROMBootPathBrowse.Location = New System.Drawing.Point(447, 96)
        Me.PROMBootPathBrowse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.PROMBootPathBrowse.Name = "PROMBootPathBrowse"
        Me.PROMBootPathBrowse.Size = New System.Drawing.Size(32, 23)
        Me.PROMBootPathBrowse.TabIndex = 34
        Me.PROMBootPathBrowse.Text = "..."
        Me.PROMBootPathBrowse.UseVisualStyleBackColor = True
        '
        'MachArgumentsLabel
        '
        Me.MachArgumentsLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachArgumentsLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MachArgumentsLabel.Location = New System.Drawing.Point(19, 128)
        Me.MachArgumentsLabel.Margin = New System.Windows.Forms.Padding(9, 6, 6, 9)
        Me.MachArgumentsLabel.Name = "MachArgumentsLabel"
        Me.MachArgumentsLabel.Size = New System.Drawing.Size(100, 13)
        Me.MachArgumentsLabel.TabIndex = 22
        Me.MachArgumentsLabel.Text = "Mach Arguments:"
        '
        'MachArguments
        '
        Me.MachArguments.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachArguments.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MachArguments.Location = New System.Drawing.Point(128, 125)
        Me.MachArguments.Name = "MachArguments"
        Me.MachArguments.Size = New System.Drawing.Size(351, 21)
        Me.MachArguments.TabIndex = 24
        '
        'BootArgumentsLabel
        '
        Me.BootArgumentsLabel.Enabled = False
        Me.BootArgumentsLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BootArgumentsLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BootArgumentsLabel.Location = New System.Drawing.Point(19, 156)
        Me.BootArgumentsLabel.Margin = New System.Windows.Forms.Padding(9, 6, 6, 9)
        Me.BootArgumentsLabel.Name = "BootArgumentsLabel"
        Me.BootArgumentsLabel.Size = New System.Drawing.Size(100, 13)
        Me.BootArgumentsLabel.TabIndex = 21
        Me.BootArgumentsLabel.Text = "Boot Arguments:"
        '
        'BootArguments
        '
        Me.BootArguments.Enabled = False
        Me.BootArguments.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BootArguments.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BootArguments.Location = New System.Drawing.Point(128, 153)
        Me.BootArguments.Name = "BootArguments"
        Me.BootArguments.Size = New System.Drawing.Size(351, 21)
        Me.BootArguments.TabIndex = 23
        '
        'GraphicDriverLabel
        '
        Me.GraphicDriverLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraphicDriverLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GraphicDriverLabel.Location = New System.Drawing.Point(19, 184)
        Me.GraphicDriverLabel.Margin = New System.Windows.Forms.Padding(9, 6, 6, 9)
        Me.GraphicDriverLabel.Name = "GraphicDriverLabel"
        Me.GraphicDriverLabel.Size = New System.Drawing.Size(100, 13)
        Me.GraphicDriverLabel.TabIndex = 37
        Me.GraphicDriverLabel.Text = "Graphic driver:"
        '
        'GraphicDriver
        '
        Me.GraphicDriver.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraphicDriver.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GraphicDriver.Location = New System.Drawing.Point(128, 181)
        Me.GraphicDriver.Name = "GraphicDriver"
        Me.GraphicDriver.Size = New System.Drawing.Size(313, 21)
        Me.GraphicDriver.TabIndex = 38
        Me.GraphicDriver.TabStop = False
        '
        'GraphicDriverBrowse
        '
        Me.GraphicDriverBrowse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraphicDriverBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GraphicDriverBrowse.Location = New System.Drawing.Point(446, 180)
        Me.GraphicDriverBrowse.Margin = New System.Windows.Forms.Padding(2)
        Me.GraphicDriverBrowse.Name = "GraphicDriverBrowse"
        Me.GraphicDriverBrowse.Size = New System.Drawing.Size(32, 23)
        Me.GraphicDriverBrowse.TabIndex = 39
        Me.GraphicDriverBrowse.TabStop = False
        Me.GraphicDriverBrowse.Text = "..."
        Me.GraphicDriverBrowse.UseVisualStyleBackColor = True
        '
        'NVRAMFileLabel
        '
        Me.NVRAMFileLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NVRAMFileLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NVRAMFileLabel.Location = New System.Drawing.Point(19, 212)
        Me.NVRAMFileLabel.Margin = New System.Windows.Forms.Padding(9, 6, 6, 9)
        Me.NVRAMFileLabel.Name = "NVRAMFileLabel"
        Me.NVRAMFileLabel.Size = New System.Drawing.Size(100, 13)
        Me.NVRAMFileLabel.TabIndex = 29
        Me.NVRAMFileLabel.Text = "NVRAM File:"
        '
        'NVRAMFile
        '
        Me.NVRAMFile.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NVRAMFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NVRAMFile.Location = New System.Drawing.Point(128, 209)
        Me.NVRAMFile.Name = "NVRAMFile"
        Me.NVRAMFile.Size = New System.Drawing.Size(313, 21)
        Me.NVRAMFile.TabIndex = 30
        '
        'NVRAMFileBrowse
        '
        Me.AdvancedSettings.SetFlowBreak(Me.NVRAMFileBrowse, True)
        Me.NVRAMFileBrowse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NVRAMFileBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NVRAMFileBrowse.Location = New System.Drawing.Point(447, 208)
        Me.NVRAMFileBrowse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.NVRAMFileBrowse.Name = "NVRAMFileBrowse"
        Me.NVRAMFileBrowse.Size = New System.Drawing.Size(32, 23)
        Me.NVRAMFileBrowse.TabIndex = 36
        Me.NVRAMFileBrowse.Text = "..."
        Me.NVRAMFileBrowse.UseVisualStyleBackColor = True
        '
        'PageTableLabel
        '
        Me.PageTableLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PageTableLabel.Location = New System.Drawing.Point(19, 240)
        Me.PageTableLabel.Margin = New System.Windows.Forms.Padding(9, 6, 6, 9)
        Me.PageTableLabel.Name = "PageTableLabel"
        Me.PageTableLabel.Size = New System.Drawing.Size(100, 13)
        Me.PageTableLabel.TabIndex = 31
        Me.PageTableLabel.Text = "Page Table:"
        '
        'PageTable
        '
        Me.PageTable.Location = New System.Drawing.Point(128, 237)
        Me.PageTable.MaxLength = 10
        Me.PageTable.Name = "PageTable"
        Me.PageTable.Size = New System.Drawing.Size(351, 20)
        Me.PageTable.TabIndex = 32
        '
        'NameSettings
        '
        Me.NameSettings.BackColor = System.Drawing.SystemColors.Window
        Me.NameSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameSettings.Controls.Add(Me.Label1)
        Me.NameSettings.Controls.Add(Me.TextBox1)
        Me.NameSettings.Controls.Add(Me.Label2)
        Me.NameSettings.Controls.Add(Me.TextBox2)
        Me.NameSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameSettings.Location = New System.Drawing.Point(193, 12)
        Me.NameSettings.Name = "NameSettings"
        Me.NameSettings.Padding = New System.Windows.Forms.Padding(10)
        Me.NameSettings.Size = New System.Drawing.Size(505, 372)
        Me.NameSettings.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(19, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(9, 6, 6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mac Name:"
        '
        'TextBox1
        '
        Me.NameSettings.SetFlowBreak(Me.TextBox1, True)
        Me.TextBox1.Location = New System.Drawing.Point(118, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(340, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(19, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(9, 6, 6, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mac Description:"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(118, 41)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(340, 60)
        Me.TextBox2.TabIndex = 3
        '
        'MiscellaneousSettings
        '
        Me.MiscellaneousSettings.BackColor = System.Drawing.SystemColors.Window
        Me.MiscellaneousSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiscellaneousSettings.Controls.Add(Me.RAMLabel)
        Me.MiscellaneousSettings.Controls.Add(Me.RAMContainer)
        Me.MiscellaneousSettings.Controls.Add(Me.EnableUSB)
        Me.MiscellaneousSettings.Controls.Add(Me.EnableSerialPort)
        Me.MiscellaneousSettings.Controls.Add(Me.ProcessorLabel)
        Me.MiscellaneousSettings.Controls.Add(Me.PPCG3)
        Me.MiscellaneousSettings.Controls.Add(Me.PPCG4)
        Me.MiscellaneousSettings.Controls.Add(Me.ChangeCDKeyLabel)
        Me.MiscellaneousSettings.Controls.Add(Me.ChangeCDKey)
        Me.MiscellaneousSettings.Controls.Add(Me.MouseGrabKeyLabel)
        Me.MiscellaneousSettings.Controls.Add(Me.MouseToggleKey)
        Me.MiscellaneousSettings.Controls.Add(Me.ComposeDialogKeyLabel)
        Me.MiscellaneousSettings.Controls.Add(Me.ComposeDialogKey)
        Me.MiscellaneousSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MiscellaneousSettings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.MiscellaneousSettings.Location = New System.Drawing.Point(193, 12)
        Me.MiscellaneousSettings.Name = "MiscellaneousSettings"
        Me.MiscellaneousSettings.Padding = New System.Windows.Forms.Padding(10)
        Me.MiscellaneousSettings.Size = New System.Drawing.Size(505, 372)
        Me.MiscellaneousSettings.TabIndex = 34
        '
        'RAMLabel
        '
        Me.RAMLabel.AutoSize = True
        Me.RAMLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAMLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RAMLabel.Location = New System.Drawing.Point(13, 10)
        Me.RAMLabel.Name = "RAMLabel"
        Me.RAMLabel.Size = New System.Drawing.Size(29, 13)
        Me.RAMLabel.TabIndex = 31
        Me.RAMLabel.Text = "RAM"
        '
        'RAMContainer
        '
        Me.RAMContainer.Controls.Add(Me.RAM)
        Me.RAMContainer.Controls.Add(Me.MB)
        Me.RAMContainer.Location = New System.Drawing.Point(13, 26)
        Me.RAMContainer.Name = "RAMContainer"
        Me.RAMContainer.Size = New System.Drawing.Size(77, 26)
        Me.RAMContainer.TabIndex = 43
        '
        'RAM
        '
        Me.RAM.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RAM.Location = New System.Drawing.Point(3, 3)
        Me.RAM.MaxLength = 4
        Me.RAM.Name = "RAM"
        Me.RAM.Size = New System.Drawing.Size(45, 21)
        Me.RAM.TabIndex = 33
        Me.RAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MB
        '
        Me.MB.AutoSize = True
        Me.MB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MB.Location = New System.Drawing.Point(51, 6)
        Me.MB.Margin = New System.Windows.Forms.Padding(0, 6, 0, 9)
        Me.MB.Name = "MB"
        Me.MB.Size = New System.Drawing.Size(21, 13)
        Me.MB.TabIndex = 34
        Me.MB.Text = "MB"
        '
        'EnableUSB
        '
        Me.EnableUSB.AutoSize = True
        Me.EnableUSB.BackColor = System.Drawing.Color.Transparent
        Me.EnableUSB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnableUSB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EnableUSB.Location = New System.Drawing.Point(13, 58)
        Me.EnableUSB.Name = "EnableUSB"
        Me.EnableUSB.Size = New System.Drawing.Size(129, 17)
        Me.EnableUSB.TabIndex = 35
        Me.EnableUSB.Text = "Enable USB emulation"
        Me.EnableUSB.UseVisualStyleBackColor = False
        '
        'EnableSerialPort
        '
        Me.EnableSerialPort.AutoSize = True
        Me.EnableSerialPort.BackColor = System.Drawing.Color.Transparent
        Me.MiscellaneousSettings.SetFlowBreak(Me.EnableSerialPort, True)
        Me.EnableSerialPort.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnableSerialPort.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EnableSerialPort.Location = New System.Drawing.Point(13, 81)
        Me.EnableSerialPort.Name = "EnableSerialPort"
        Me.EnableSerialPort.Size = New System.Drawing.Size(151, 17)
        Me.EnableSerialPort.TabIndex = 42
        Me.EnableSerialPort.Text = "Enable serial port (Debug)"
        Me.EnableSerialPort.UseVisualStyleBackColor = False
        '
        'ProcessorLabel
        '
        Me.ProcessorLabel.AutoSize = True
        Me.ProcessorLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessorLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ProcessorLabel.Location = New System.Drawing.Point(195, 13)
        Me.ProcessorLabel.Margin = New System.Windows.Forms.Padding(28, 3, 28, 3)
        Me.ProcessorLabel.Name = "ProcessorLabel"
        Me.ProcessorLabel.Size = New System.Drawing.Size(58, 13)
        Me.ProcessorLabel.TabIndex = 32
        Me.ProcessorLabel.Text = "Processor:"
        '
        'PPCG3
        '
        Me.PPCG3.AutoSize = True
        Me.PPCG3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PPCG3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PPCG3.Location = New System.Drawing.Point(195, 32)
        Me.PPCG3.Margin = New System.Windows.Forms.Padding(28, 3, 28, 3)
        Me.PPCG3.Name = "PPCG3"
        Me.PPCG3.Size = New System.Drawing.Size(151, 17)
        Me.PPCG3.TabIndex = 30
        Me.PPCG3.Text = "PowerPC G3 (more stable)"
        Me.PPCG3.UseVisualStyleBackColor = True
        '
        'PPCG4
        '
        Me.PPCG4.AutoSize = True
        Me.MiscellaneousSettings.SetFlowBreak(Me.PPCG4, True)
        Me.PPCG4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PPCG4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PPCG4.Location = New System.Drawing.Point(195, 55)
        Me.PPCG4.Margin = New System.Windows.Forms.Padding(28, 3, 28, 3)
        Me.PPCG4.Name = "PPCG4"
        Me.PPCG4.Size = New System.Drawing.Size(84, 17)
        Me.PPCG4.TabIndex = 29
        Me.PPCG4.Text = "PowerPC G4"
        Me.PPCG4.UseVisualStyleBackColor = True
        '
        'ChangeCDKeyLabel
        '
        Me.ChangeCDKeyLabel.AutoSize = True
        Me.ChangeCDKeyLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChangeCDKeyLabel.Location = New System.Drawing.Point(377, 13)
        Me.ChangeCDKeyLabel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.ChangeCDKeyLabel.Name = "ChangeCDKeyLabel"
        Me.ChangeCDKeyLabel.Size = New System.Drawing.Size(82, 13)
        Me.ChangeCDKeyLabel.TabIndex = 39
        Me.ChangeCDKeyLabel.Text = "Change CD key"
        '
        'ChangeCDKey
        '
        Me.ChangeCDKey.Location = New System.Drawing.Point(377, 29)
        Me.ChangeCDKey.Name = "ChangeCDKey"
        Me.ChangeCDKey.Size = New System.Drawing.Size(78, 20)
        Me.ChangeCDKey.TabIndex = 38
        Me.ChangeCDKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MouseGrabKeyLabel
        '
        Me.MouseGrabKeyLabel.AutoSize = True
        Me.MouseGrabKeyLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MouseGrabKeyLabel.Location = New System.Drawing.Point(377, 52)
        Me.MouseGrabKeyLabel.Name = "MouseGrabKeyLabel"
        Me.MouseGrabKeyLabel.Size = New System.Drawing.Size(83, 13)
        Me.MouseGrabKeyLabel.TabIndex = 37
        Me.MouseGrabKeyLabel.Text = "Mouse grab key"
        '
        'MouseToggleKey
        '
        Me.MouseToggleKey.Location = New System.Drawing.Point(377, 68)
        Me.MouseToggleKey.Name = "MouseToggleKey"
        Me.MouseToggleKey.Size = New System.Drawing.Size(78, 20)
        Me.MouseToggleKey.TabIndex = 36
        Me.MouseToggleKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComposeDialogKeyLabel
        '
        Me.ComposeDialogKeyLabel.AutoSize = True
        Me.ComposeDialogKeyLabel.BackColor = System.Drawing.Color.Transparent
        Me.ComposeDialogKeyLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComposeDialogKeyLabel.Location = New System.Drawing.Point(377, 91)
        Me.ComposeDialogKeyLabel.Name = "ComposeDialogKeyLabel"
        Me.ComposeDialogKeyLabel.Size = New System.Drawing.Size(102, 13)
        Me.ComposeDialogKeyLabel.TabIndex = 41
        Me.ComposeDialogKeyLabel.Text = "Compose dialog key"
        '
        'ComposeDialogKey
        '
        Me.MiscellaneousSettings.SetFlowBreak(Me.ComposeDialogKey, True)
        Me.ComposeDialogKey.Location = New System.Drawing.Point(377, 107)
        Me.ComposeDialogKey.Name = "ComposeDialogKey"
        Me.ComposeDialogKey.Size = New System.Drawing.Size(78, 20)
        Me.ComposeDialogKey.TabIndex = 40
        Me.ComposeDialogKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SaveConfigFile
        '
        Me.SaveConfigFile.FileName = "PearPC"
        Me.SaveConfigFile.Filter = "PearPC Configuration Files (*.cfg)|*.cfg|All files (*.*)|*.*"
        '
        'frmSettings
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(710, 416)
        Me.Controls.Add(Me.GraphicSettings)
        Me.Controls.Add(Me.NameSettings)
        Me.Controls.Add(Me.DisksSettings)
        Me.Controls.Add(Me.NetworkSettings)
        Me.Controls.Add(Me.MiscellaneousSettings)
        Me.Controls.Add(Me.AdvancedSettings)
        Me.Controls.Add(Me.SettingsPicker)
        Me.Controls.Add(Me.cmdContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmSettings"
        Me.Padding = New System.Windows.Forms.Padding(12, 12, 12, 0)
        Me.Text = "Settings"
        CType(Me.Frequency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GraphicSettings.ResumeLayout(False)
        Me.GraphicSettings.PerformLayout()
        Me.DisksSettings.ResumeLayout(False)
        Me.DisksSettings.PerformLayout()
        Me.cmdContainer.ResumeLayout(False)
        Me.NetworkSettings.ResumeLayout(False)
        Me.NetworkSettings.PerformLayout()
        Me.AdvancedSettings.ResumeLayout(False)
        Me.AdvancedSettings.PerformLayout()
        Me.NameSettings.ResumeLayout(False)
        Me.NameSettings.PerformLayout()
        Me.MiscellaneousSettings.ResumeLayout(False)
        Me.MiscellaneousSettings.PerformLayout()
        Me.RAMContainer.ResumeLayout(False)
        Me.RAMContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents BitDepth As System.Windows.Forms.ComboBox
    Friend WithEvents Resolution As System.Windows.Forms.Label
    Friend WithEvents FullscreenCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Fullscreen As System.Windows.Forms.Label
    Friend WithEvents Browser As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToggleFullscreenKeyLabel As System.Windows.Forms.Label
    Friend WithEvents ToggleFullscreenKey As System.Windows.Forms.TextBox
    Friend WithEvents Redraw As System.Windows.Forms.Label
    Friend WithEvents RedrawTime As System.Windows.Forms.TextBox
    Friend WithEvents Frequency As System.Windows.Forms.NumericUpDown
    Friend WithEvents MasterDriveTypeLabel As System.Windows.Forms.Label
    Friend WithEvents MasterLocLabel As System.Windows.Forms.Label
    Friend WithEvents MasterLoc As System.Windows.Forms.TextBox
    Friend WithEvents MasterEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents MasterDriveType As System.Windows.Forms.ComboBox
    Friend WithEvents MasterLocBrowse As System.Windows.Forms.Button
    Friend WithEvents SelectDrive As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SlaveLocBrowse As System.Windows.Forms.Button
    Friend WithEvents SlaveDriveTypeLabel As System.Windows.Forms.Label
    Friend WithEvents SlaveLocLabel As System.Windows.Forms.Label
    Friend WithEvents SlaveLoc As System.Windows.Forms.TextBox
    Friend WithEvents SlaveEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents SlaveDriveType As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents SettingsPicker As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GraphicSettings As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents XCustomResolution As System.Windows.Forms.ComboBox
    Friend WithEvents YCustomResolution As System.Windows.Forms.ComboBox
    Friend WithEvents DisksSettings As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cmdContainer As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents NetworkSettings As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Net8139MacLabel As System.Windows.Forms.Label
    Friend WithEvents Net3c90MacLabel As System.Windows.Forms.Label
    Friend WithEvents Mac68139 As System.Windows.Forms.TextBox
    Friend WithEvents Mac58139 As System.Windows.Forms.TextBox
    Friend WithEvents Mac48139 As System.Windows.Forms.TextBox
    Friend WithEvents Mac38139 As System.Windows.Forms.TextBox
    Friend WithEvents Mac28139 As System.Windows.Forms.TextBox
    Friend WithEvents Mac18139 As System.Windows.Forms.TextBox
    Friend WithEvents Mac63c90 As System.Windows.Forms.TextBox
    Friend WithEvents Mac53c90 As System.Windows.Forms.TextBox
    Friend WithEvents Mac43c90 As System.Windows.Forms.TextBox
    Friend WithEvents Mac33c90 As System.Windows.Forms.TextBox
    Friend WithEvents Mac23c90 As System.Windows.Forms.TextBox
    Friend WithEvents Mac13c90 As System.Windows.Forms.TextBox
    Friend WithEvents NetRTL8139 As System.Windows.Forms.CheckBox
    Friend WithEvents Net3c90x As System.Windows.Forms.CheckBox
    Friend WithEvents AdvancedSettings As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents NameSettings As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents MiscellaneousSettings As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ProcessorLabel As System.Windows.Forms.Label
    Friend WithEvents PPCG3 As System.Windows.Forms.RadioButton
    Friend WithEvents PPCG4 As System.Windows.Forms.RadioButton
    Friend WithEvents EnableSerialPort As System.Windows.Forms.CheckBox
    Friend WithEvents ComposeDialogKeyLabel As System.Windows.Forms.Label
    Friend WithEvents ComposeDialogKey As System.Windows.Forms.TextBox
    Friend WithEvents ChangeCDKeyLabel As System.Windows.Forms.Label
    Friend WithEvents ChangeCDKey As System.Windows.Forms.TextBox
    Friend WithEvents MouseGrabKeyLabel As System.Windows.Forms.Label
    Friend WithEvents EnableUSB As System.Windows.Forms.CheckBox
    Friend WithEvents MouseToggleKey As System.Windows.Forms.TextBox
    Friend WithEvents MB As System.Windows.Forms.Label
    Friend WithEvents RAM As System.Windows.Forms.TextBox
    Friend WithEvents RAMLabel As System.Windows.Forms.Label
    Friend WithEvents RAMContainer As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents AdvancedWarning As System.Windows.Forms.Label
    Friend WithEvents PageTable As System.Windows.Forms.TextBox
    Friend WithEvents PageTableLabel As System.Windows.Forms.Label
    Friend WithEvents NVRAMFile As System.Windows.Forms.TextBox
    Friend WithEvents NVRAMFileLabel As System.Windows.Forms.Label
    Friend WithEvents BootMode As System.Windows.Forms.Label
    Friend WithEvents BootAuto As System.Windows.Forms.RadioButton
    Friend WithEvents BootSelect As System.Windows.Forms.RadioButton
    Friend WithEvents BootForce As System.Windows.Forms.RadioButton
    Friend WithEvents MachArguments As System.Windows.Forms.TextBox
    Friend WithEvents BootArguments As System.Windows.Forms.TextBox
    Friend WithEvents MachArgumentsLabel As System.Windows.Forms.Label
    Friend WithEvents BootArgumentsLabel As System.Windows.Forms.Label
    Friend WithEvents PROMBootPath As System.Windows.Forms.TextBox
    Friend WithEvents PROMFile As System.Windows.Forms.TextBox
    Friend WithEvents PROMBootPathLabel As System.Windows.Forms.Label
    Friend WithEvents PROMFileLabel As System.Windows.Forms.Label
    Friend WithEvents PROMFileBrowse As System.Windows.Forms.Button
    Friend WithEvents PROMBootPathBrowse As System.Windows.Forms.Button
    Friend WithEvents NVRAMFileBrowse As System.Windows.Forms.Button
    Friend WithEvents GraphicDriverLabel As System.Windows.Forms.Label
    Friend WithEvents GraphicDriver As System.Windows.Forms.TextBox
    Friend WithEvents GraphicDriverBrowse As System.Windows.Forms.Button
    Friend WithEvents SaveConfigFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

End Class
