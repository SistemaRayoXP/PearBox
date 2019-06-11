<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Máquina 1", "Saved"}, 0)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Máquina 2", "Not running"}, 4)
        Me.tbAction = New System.Windows.Forms.ToolStrip()
        Me.tbActionNew = New System.Windows.Forms.ToolStripButton()
        Me.tbActionConfig = New System.Windows.Forms.ToolStripButton()
        Me.tbDelete = New System.Windows.Forms.ToolStripButton()
        Me.tbStart = New System.Windows.Forms.ToolStripButton()
        Me.tbTestLabel = New System.Windows.Forms.ToolStripLabel()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFilePrefs = New System.Windows.Forms.MenuItem()
        Me.mnuMachine = New System.Windows.Forms.MenuItem()
        Me.mnuMachineNew = New System.Windows.Forms.MenuItem()
        Me.mnuMachineAdd = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.MenuItem()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.VMPics = New System.Windows.Forms.ImageList(Me.components)
        Me.lvVmlist = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panMain = New System.Windows.Forms.ScrollableControl()
        Me.panDetFlowContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.panDetSys = New System.Windows.Forms.Panel()
        Me.panDetSysPic = New System.Windows.Forms.PictureBox()
        Me.panDetSysLink = New System.Windows.Forms.LinkLabel()
        Me.panDetSysCollapse = New System.Windows.Forms.Button()
        Me.panDetSysControls = New System.Windows.Forms.FlowLayoutPanel()
        Me.panDetNet = New System.Windows.Forms.Panel()
        Me.panDetNetPic = New System.Windows.Forms.PictureBox()
        Me.panDetNetLink = New System.Windows.Forms.LinkLabel()
        Me.panDetNetCollapse = New System.Windows.Forms.Button()
        Me.panDetNetControls = New System.Windows.Forms.FlowLayoutPanel()
        Me.panDetBoot = New System.Windows.Forms.Panel()
        Me.panDetBootPic = New System.Windows.Forms.PictureBox()
        Me.panDetBootLink = New System.Windows.Forms.LinkLabel()
        Me.panDetBootCollapse = New System.Windows.Forms.Button()
        Me.panDetBootControls = New System.Windows.Forms.FlowLayoutPanel()
        Me.panDetKeys = New System.Windows.Forms.Panel()
        Me.panDetKeysPic = New System.Windows.Forms.PictureBox()
        Me.panDetKeysLink = New System.Windows.Forms.LinkLabel()
        Me.panDetKeysCollapse = New System.Windows.Forms.Button()
        Me.panDetKeysControls = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panWelcomePic = New System.Windows.Forms.PictureBox()
        Me.panWelcomeDescription = New System.Windows.Forms.Label()
        Me.panWelcomeTitle = New System.Windows.Forms.Label()
        Me.tbAction.SuspendLayout()
        Me.panMain.SuspendLayout()
        Me.panDetFlowContainer.SuspendLayout()
        Me.panDetSys.SuspendLayout()
        CType(Me.panDetSysPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panDetNet.SuspendLayout()
        CType(Me.panDetNetPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panDetBoot.SuspendLayout()
        CType(Me.panDetBootPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panDetKeys.SuspendLayout()
        CType(Me.panDetKeysPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.panWelcomePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbAction
        '
        Me.tbAction.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tbAction.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbAction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbActionNew, Me.tbActionConfig, Me.tbDelete, Me.tbStart, Me.tbTestLabel})
        Me.tbAction.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tbAction.Location = New System.Drawing.Point(0, 0)
        Me.tbAction.Name = "tbAction"
        Me.tbAction.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tbAction.Size = New System.Drawing.Size(659, 54)
        Me.tbAction.TabIndex = 0
        Me.tbAction.Text = "ToolStrip1"
        '
        'tbActionNew
        '
        Me.tbActionNew.Image = Global.PearBox.My.Resources.Resources.MachineNew
        Me.tbActionNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbActionNew.Name = "tbActionNew"
        Me.tbActionNew.Size = New System.Drawing.Size(36, 51)
        Me.tbActionNew.Text = "New"
        Me.tbActionNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tbActionConfig
        '
        Me.tbActionConfig.Enabled = False
        Me.tbActionConfig.Image = Global.PearBox.My.Resources.Resources.MachineConfig
        Me.tbActionConfig.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbActionConfig.Name = "tbActionConfig"
        Me.tbActionConfig.Size = New System.Drawing.Size(85, 51)
        Me.tbActionConfig.Text = "Configuration"
        Me.tbActionConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tbDelete
        '
        Me.tbDelete.Enabled = False
        Me.tbDelete.Image = Global.PearBox.My.Resources.Resources.MachineDelete
        Me.tbDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbDelete.Name = "tbDelete"
        Me.tbDelete.Size = New System.Drawing.Size(44, 51)
        Me.tbDelete.Text = "Delete"
        Me.tbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tbStart
        '
        Me.tbStart.Enabled = False
        Me.tbStart.Image = Global.PearBox.My.Resources.Resources.MachineStart
        Me.tbStart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbStart.Name = "tbStart"
        Me.tbStart.Size = New System.Drawing.Size(36, 51)
        Me.tbStart.Text = "Start"
        Me.tbStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tbTestLabel
        '
        Me.tbTestLabel.Name = "tbTestLabel"
        Me.tbTestLabel.Size = New System.Drawing.Size(35, 51)
        Me.tbTestLabel.Text = "Test1"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuMachine, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFilePrefs})
        Me.mnuFile.Text = "File"
        '
        'mnuFilePrefs
        '
        Me.mnuFilePrefs.Index = 0
        Me.mnuFilePrefs.Text = "Preferences"
        '
        'mnuMachine
        '
        Me.mnuMachine.Index = 1
        Me.mnuMachine.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMachineNew, Me.mnuMachineAdd})
        Me.mnuMachine.Text = "Machine"
        '
        'mnuMachineNew
        '
        Me.mnuMachineNew.Index = 0
        Me.mnuMachineNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.mnuMachineNew.Text = "New"
        '
        'mnuMachineAdd
        '
        Me.mnuMachineAdd.Index = 1
        Me.mnuMachineAdd.Text = "Add"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Index = 0
        Me.mnuHelpAbout.Text = "About"
        '
        'OpenFile
        '
        Me.OpenFile.FileName = "OpenFileDialog1"
        '
        'VMPics
        '
        Me.VMPics.ImageStream = CType(resources.GetObject("VMPics.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.VMPics.TransparentColor = System.Drawing.Color.Transparent
        Me.VMPics.Images.SetKeyName(0, "Generic.png")
        Me.VMPics.Images.SetKeyName(1, "MacOS.png")
        Me.VMPics.Images.SetKeyName(2, "Cheetah.png")
        Me.VMPics.Images.SetKeyName(3, "Panther.png")
        Me.VMPics.Images.SetKeyName(4, "Tiger.png")
        Me.VMPics.Images.SetKeyName(5, "Linux.png")
        '
        'lvVmlist
        '
        Me.lvVmlist.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvVmlist.BackColor = System.Drawing.SystemColors.Window
        Me.lvVmlist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvVmlist.Dock = System.Windows.Forms.DockStyle.Left
        Me.lvVmlist.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvVmlist.FullRowSelect = True
        Me.lvVmlist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvVmlist.HideSelection = False
        Me.lvVmlist.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.lvVmlist.LabelWrap = False
        Me.lvVmlist.LargeImageList = Me.VMPics
        Me.lvVmlist.Location = New System.Drawing.Point(0, 54)
        Me.lvVmlist.MultiSelect = False
        Me.lvVmlist.Name = "lvVmlist"
        Me.lvVmlist.ShowGroups = False
        Me.lvVmlist.ShowItemToolTips = True
        Me.lvVmlist.Size = New System.Drawing.Size(253, 309)
        Me.lvVmlist.SmallImageList = Me.VMPics
        Me.lvVmlist.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvVmlist.TabIndex = 3
        Me.lvVmlist.TileSize = New System.Drawing.Size(200, 50)
        Me.lvVmlist.UseCompatibleStateImageBehavior = False
        Me.lvVmlist.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 249
        '
        'panMain
        '
        Me.panMain.AutoScroll = True
        Me.panMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.panMain.Controls.Add(Me.panDetFlowContainer)
        Me.panMain.Controls.Add(Me.Panel1)
        Me.panMain.Location = New System.Drawing.Point(259, 54)
        Me.panMain.Name = "panMain"
        Me.panMain.Size = New System.Drawing.Size(400, 351)
        Me.panMain.TabIndex = 4
        Me.panMain.Text = "ScrollableControl1"
        '
        'panDetFlowContainer
        '
        Me.panDetFlowContainer.AutoScroll = True
        Me.panDetFlowContainer.AutoSize = True
        Me.panDetFlowContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panDetFlowContainer.BackgroundImage = Global.PearBox.My.Resources.Resources.Apple
        Me.panDetFlowContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.panDetFlowContainer.Controls.Add(Me.panDetSys)
        Me.panDetFlowContainer.Controls.Add(Me.panDetNet)
        Me.panDetFlowContainer.Controls.Add(Me.panDetBoot)
        Me.panDetFlowContainer.Controls.Add(Me.panDetKeys)
        Me.panDetFlowContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panDetFlowContainer.Location = New System.Drawing.Point(0, 0)
        Me.panDetFlowContainer.Name = "panDetFlowContainer"
        Me.panDetFlowContainer.Size = New System.Drawing.Size(400, 351)
        Me.panDetFlowContainer.TabIndex = 11
        '
        'panDetSys
        '
        Me.panDetSys.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panDetSys.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.panDetSys.Controls.Add(Me.panDetSysPic)
        Me.panDetSys.Controls.Add(Me.panDetSysLink)
        Me.panDetSys.Controls.Add(Me.panDetSysCollapse)
        Me.panDetSys.Controls.Add(Me.panDetSysControls)
        Me.panDetSys.Dock = System.Windows.Forms.DockStyle.Top
        Me.panDetSys.Location = New System.Drawing.Point(3, 3)
        Me.panDetSys.Name = "panDetSys"
        Me.panDetSys.Size = New System.Drawing.Size(394, 49)
        Me.panDetSys.TabIndex = 0
        '
        'panDetSysPic
        '
        Me.panDetSysPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panDetSysPic.Image = Global.PearBox.My.Resources.Resources.Chipset
        Me.panDetSysPic.Location = New System.Drawing.Point(3, 2)
        Me.panDetSysPic.Name = "panDetSysPic"
        Me.panDetSysPic.Size = New System.Drawing.Size(16, 16)
        Me.panDetSysPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.panDetSysPic.TabIndex = 7
        Me.panDetSysPic.TabStop = False
        '
        'panDetSysLink
        '
        Me.panDetSysLink.ActiveLinkColor = System.Drawing.Color.Blue
        Me.panDetSysLink.AutoSize = True
        Me.panDetSysLink.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panDetSysLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.panDetSysLink.LinkColor = System.Drawing.SystemColors.ControlText
        Me.panDetSysLink.Location = New System.Drawing.Point(22, 2)
        Me.panDetSysLink.Name = "panDetSysLink"
        Me.panDetSysLink.Size = New System.Drawing.Size(50, 13)
        Me.panDetSysLink.TabIndex = 1
        Me.panDetSysLink.TabStop = True
        Me.panDetSysLink.Text = "System"
        Me.panDetSysLink.VisitedLinkColor = System.Drawing.SystemColors.ControlText
        '
        'panDetSysCollapse
        '
        Me.panDetSysCollapse.BackColor = System.Drawing.Color.Transparent
        Me.panDetSysCollapse.BackgroundImage = Global.PearBox.My.Resources.Resources.ArrowUp
        Me.panDetSysCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.panDetSysCollapse.FlatAppearance.BorderSize = 0
        Me.panDetSysCollapse.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panDetSysCollapse.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.panDetSysCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.panDetSysCollapse.Location = New System.Drawing.Point(368, 0)
        Me.panDetSysCollapse.Name = "panDetSysCollapse"
        Me.panDetSysCollapse.Size = New System.Drawing.Size(29, 19)
        Me.panDetSysCollapse.TabIndex = 7
        Me.panDetSysCollapse.UseVisualStyleBackColor = False
        '
        'panDetSysControls
        '
        Me.panDetSysControls.BackColor = System.Drawing.SystemColors.Window
        Me.panDetSysControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panDetSysControls.Location = New System.Drawing.Point(3, 18)
        Me.panDetSysControls.Name = "panDetSysControls"
        Me.panDetSysControls.Size = New System.Drawing.Size(388, 29)
        Me.panDetSysControls.TabIndex = 4
        '
        'panDetNet
        '
        Me.panDetNet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panDetNet.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.panDetNet.Controls.Add(Me.panDetNetPic)
        Me.panDetNet.Controls.Add(Me.panDetNetLink)
        Me.panDetNet.Controls.Add(Me.panDetNetCollapse)
        Me.panDetNet.Controls.Add(Me.panDetNetControls)
        Me.panDetNet.Location = New System.Drawing.Point(3, 58)
        Me.panDetNet.Name = "panDetNet"
        Me.panDetNet.Size = New System.Drawing.Size(394, 49)
        Me.panDetNet.TabIndex = 2
        '
        'panDetNetPic
        '
        Me.panDetNetPic.BackgroundImage = Global.PearBox.My.Resources.Resources.Chipset
        Me.panDetNetPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panDetNetPic.Image = Global.PearBox.My.Resources.Resources.Network
        Me.panDetNetPic.Location = New System.Drawing.Point(3, 2)
        Me.panDetNetPic.Name = "panDetNetPic"
        Me.panDetNetPic.Size = New System.Drawing.Size(16, 16)
        Me.panDetNetPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.panDetNetPic.TabIndex = 8
        Me.panDetNetPic.TabStop = False
        '
        'panDetNetLink
        '
        Me.panDetNetLink.ActiveLinkColor = System.Drawing.Color.Blue
        Me.panDetNetLink.AutoSize = True
        Me.panDetNetLink.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panDetNetLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.panDetNetLink.LinkColor = System.Drawing.SystemColors.ControlText
        Me.panDetNetLink.Location = New System.Drawing.Point(22, 2)
        Me.panDetNetLink.Name = "panDetNetLink"
        Me.panDetNetLink.Size = New System.Drawing.Size(54, 13)
        Me.panDetNetLink.TabIndex = 1
        Me.panDetNetLink.TabStop = True
        Me.panDetNetLink.Text = "Network"
        Me.panDetNetLink.VisitedLinkColor = System.Drawing.SystemColors.ControlText
        '
        'panDetNetCollapse
        '
        Me.panDetNetCollapse.BackColor = System.Drawing.Color.Transparent
        Me.panDetNetCollapse.BackgroundImage = Global.PearBox.My.Resources.Resources.ArrowUp
        Me.panDetNetCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.panDetNetCollapse.FlatAppearance.BorderSize = 0
        Me.panDetNetCollapse.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panDetNetCollapse.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.panDetNetCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.panDetNetCollapse.Location = New System.Drawing.Point(368, 0)
        Me.panDetNetCollapse.Name = "panDetNetCollapse"
        Me.panDetNetCollapse.Size = New System.Drawing.Size(29, 19)
        Me.panDetNetCollapse.TabIndex = 10
        Me.panDetNetCollapse.UseVisualStyleBackColor = False
        '
        'panDetNetControls
        '
        Me.panDetNetControls.BackColor = System.Drawing.SystemColors.Window
        Me.panDetNetControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panDetNetControls.Location = New System.Drawing.Point(3, 18)
        Me.panDetNetControls.Name = "panDetNetControls"
        Me.panDetNetControls.Size = New System.Drawing.Size(388, 29)
        Me.panDetNetControls.TabIndex = 5
        '
        'panDetBoot
        '
        Me.panDetBoot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panDetBoot.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.panDetBoot.Controls.Add(Me.panDetBootPic)
        Me.panDetBoot.Controls.Add(Me.panDetBootLink)
        Me.panDetBoot.Controls.Add(Me.panDetBootCollapse)
        Me.panDetBoot.Controls.Add(Me.panDetBootControls)
        Me.panDetBoot.Location = New System.Drawing.Point(3, 113)
        Me.panDetBoot.Name = "panDetBoot"
        Me.panDetBoot.Size = New System.Drawing.Size(394, 49)
        Me.panDetBoot.TabIndex = 3
        '
        'panDetBootPic
        '
        Me.panDetBootPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panDetBootPic.Image = Global.PearBox.My.Resources.Resources.HardDisk
        Me.panDetBootPic.Location = New System.Drawing.Point(3, 2)
        Me.panDetBootPic.Name = "panDetBootPic"
        Me.panDetBootPic.Size = New System.Drawing.Size(16, 16)
        Me.panDetBootPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.panDetBootPic.TabIndex = 8
        Me.panDetBootPic.TabStop = False
        '
        'panDetBootLink
        '
        Me.panDetBootLink.ActiveLinkColor = System.Drawing.Color.Blue
        Me.panDetBootLink.AutoSize = True
        Me.panDetBootLink.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panDetBootLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.panDetBootLink.LinkColor = System.Drawing.SystemColors.ControlText
        Me.panDetBootLink.Location = New System.Drawing.Point(22, 2)
        Me.panDetBootLink.Name = "panDetBootLink"
        Me.panDetBootLink.Size = New System.Drawing.Size(33, 13)
        Me.panDetBootLink.TabIndex = 1
        Me.panDetBootLink.TabStop = True
        Me.panDetBootLink.Text = "Boot"
        Me.panDetBootLink.VisitedLinkColor = System.Drawing.SystemColors.ControlText
        '
        'panDetBootCollapse
        '
        Me.panDetBootCollapse.BackColor = System.Drawing.Color.Transparent
        Me.panDetBootCollapse.BackgroundImage = Global.PearBox.My.Resources.Resources.ArrowUp
        Me.panDetBootCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.panDetBootCollapse.FlatAppearance.BorderSize = 0
        Me.panDetBootCollapse.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panDetBootCollapse.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.panDetBootCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.panDetBootCollapse.Location = New System.Drawing.Point(368, 0)
        Me.panDetBootCollapse.Name = "panDetBootCollapse"
        Me.panDetBootCollapse.Size = New System.Drawing.Size(29, 19)
        Me.panDetBootCollapse.TabIndex = 10
        Me.panDetBootCollapse.UseVisualStyleBackColor = False
        '
        'panDetBootControls
        '
        Me.panDetBootControls.BackColor = System.Drawing.SystemColors.Window
        Me.panDetBootControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panDetBootControls.Location = New System.Drawing.Point(3, 18)
        Me.panDetBootControls.Name = "panDetBootControls"
        Me.panDetBootControls.Size = New System.Drawing.Size(388, 29)
        Me.panDetBootControls.TabIndex = 11
        '
        'panDetKeys
        '
        Me.panDetKeys.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panDetKeys.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.panDetKeys.Controls.Add(Me.panDetKeysPic)
        Me.panDetKeys.Controls.Add(Me.panDetKeysLink)
        Me.panDetKeys.Controls.Add(Me.panDetKeysCollapse)
        Me.panDetKeys.Controls.Add(Me.panDetKeysControls)
        Me.panDetKeys.Location = New System.Drawing.Point(3, 168)
        Me.panDetKeys.Name = "panDetKeys"
        Me.panDetKeys.Size = New System.Drawing.Size(394, 49)
        Me.panDetKeys.TabIndex = 2
        '
        'panDetKeysPic
        '
        Me.panDetKeysPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panDetKeysPic.Image = Global.PearBox.My.Resources.Resources.PC_alt
        Me.panDetKeysPic.Location = New System.Drawing.Point(3, 2)
        Me.panDetKeysPic.Name = "panDetKeysPic"
        Me.panDetKeysPic.Size = New System.Drawing.Size(16, 16)
        Me.panDetKeysPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.panDetKeysPic.TabIndex = 8
        Me.panDetKeysPic.TabStop = False
        '
        'panDetKeysLink
        '
        Me.panDetKeysLink.ActiveLinkColor = System.Drawing.Color.Blue
        Me.panDetKeysLink.AutoSize = True
        Me.panDetKeysLink.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panDetKeysLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.panDetKeysLink.LinkColor = System.Drawing.SystemColors.ControlText
        Me.panDetKeysLink.Location = New System.Drawing.Point(22, 2)
        Me.panDetKeysLink.Name = "panDetKeysLink"
        Me.panDetKeysLink.Size = New System.Drawing.Size(54, 13)
        Me.panDetKeysLink.TabIndex = 1
        Me.panDetKeysLink.TabStop = True
        Me.panDetKeysLink.Text = "Hotkeys"
        Me.panDetKeysLink.VisitedLinkColor = System.Drawing.SystemColors.ControlText
        '
        'panDetKeysCollapse
        '
        Me.panDetKeysCollapse.BackColor = System.Drawing.Color.Transparent
        Me.panDetKeysCollapse.BackgroundImage = Global.PearBox.My.Resources.Resources.ArrowUp
        Me.panDetKeysCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.panDetKeysCollapse.FlatAppearance.BorderSize = 0
        Me.panDetKeysCollapse.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panDetKeysCollapse.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.panDetKeysCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.panDetKeysCollapse.Location = New System.Drawing.Point(368, 0)
        Me.panDetKeysCollapse.Name = "panDetKeysCollapse"
        Me.panDetKeysCollapse.Size = New System.Drawing.Size(29, 19)
        Me.panDetKeysCollapse.TabIndex = 9
        Me.panDetKeysCollapse.UseVisualStyleBackColor = False
        '
        'panDetKeysControls
        '
        Me.panDetKeysControls.BackColor = System.Drawing.SystemColors.Window
        Me.panDetKeysControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panDetKeysControls.Location = New System.Drawing.Point(3, 18)
        Me.panDetKeysControls.Name = "panDetKeysControls"
        Me.panDetKeysControls.Size = New System.Drawing.Size(388, 29)
        Me.panDetKeysControls.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.panWelcomePic)
        Me.Panel1.Controls.Add(Me.panWelcomeDescription)
        Me.Panel1.Controls.Add(Me.panWelcomeTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 351)
        Me.Panel1.TabIndex = 4
        '
        'panWelcomePic
        '
        Me.panWelcomePic.BackColor = System.Drawing.Color.Transparent
        Me.panWelcomePic.Image = Global.PearBox.My.Resources.Resources.mnuHelpAbout_Image
        Me.panWelcomePic.Location = New System.Drawing.Point(242, 3)
        Me.panWelcomePic.Name = "panWelcomePic"
        Me.panWelcomePic.Size = New System.Drawing.Size(155, 170)
        Me.panWelcomePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.panWelcomePic.TabIndex = 2
        Me.panWelcomePic.TabStop = False
        '
        'panWelcomeDescription
        '
        Me.panWelcomeDescription.BackColor = System.Drawing.Color.Transparent
        Me.panWelcomeDescription.Location = New System.Drawing.Point(5, 35)
        Me.panWelcomeDescription.Name = "panWelcomeDescription"
        Me.panWelcomeDescription.Size = New System.Drawing.Size(224, 34)
        Me.panWelcomeDescription.TabIndex = 4
        Me.panWelcomeDescription.Text = "This is the third spiritual release of PearPC's Virtualbox-like GUI"
        '
        'panWelcomeTitle
        '
        Me.panWelcomeTitle.AutoSize = True
        Me.panWelcomeTitle.BackColor = System.Drawing.Color.Transparent
        Me.panWelcomeTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.panWelcomeTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panWelcomeTitle.Location = New System.Drawing.Point(0, 0)
        Me.panWelcomeTitle.MinimumSize = New System.Drawing.Size(175, 0)
        Me.panWelcomeTitle.Name = "panWelcomeTitle"
        Me.panWelcomeTitle.Padding = New System.Windows.Forms.Padding(5, 10, 0, 0)
        Me.panWelcomeTitle.Size = New System.Drawing.Size(175, 26)
        Me.panWelcomeTitle.TabIndex = 3
        Me.panWelcomeTitle.Text = "Welcome to PearBox 3.0!"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 363)
        Me.Controls.Add(Me.lvVmlist)
        Me.Controls.Add(Me.panMain)
        Me.Controls.Add(Me.tbAction)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.MinimumSize = New System.Drawing.Size(270, 36)
        Me.Name = "frmMain"
        Me.Text = "PearBox"
        Me.tbAction.ResumeLayout(False)
        Me.tbAction.PerformLayout()
        Me.panMain.ResumeLayout(False)
        Me.panMain.PerformLayout()
        Me.panDetFlowContainer.ResumeLayout(False)
        Me.panDetSys.ResumeLayout(False)
        Me.panDetSys.PerformLayout()
        CType(Me.panDetSysPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panDetNet.ResumeLayout(False)
        Me.panDetNet.PerformLayout()
        CType(Me.panDetNetPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panDetBoot.ResumeLayout(False)
        Me.panDetBoot.PerformLayout()
        CType(Me.panDetBootPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panDetKeys.ResumeLayout(False)
        Me.panDetKeys.PerformLayout()
        CType(Me.panDetKeysPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.panWelcomePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbAction As System.Windows.Forms.ToolStrip
    Friend WithEvents tbStart As System.Windows.Forms.ToolStripButton
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tbActionNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbActionConfig As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuFilePrefs As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMachine As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMachineNew As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMachineAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.MenuItem
    Friend WithEvents VMPics As System.Windows.Forms.ImageList
    Friend WithEvents panWelcomePic As System.Windows.Forms.PictureBox
    Friend WithEvents lvVmlist As System.Windows.Forms.ListView
    Friend WithEvents panMain As System.Windows.Forms.ScrollableControl
    Friend WithEvents panWelcomeTitle As System.Windows.Forms.Label
    Friend WithEvents panWelcomeDescription As System.Windows.Forms.Label
    Friend WithEvents tbTestLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents panDetSys As System.Windows.Forms.Panel
    Friend WithEvents panDetSysLink As System.Windows.Forms.LinkLabel
    Friend WithEvents panDetNet As System.Windows.Forms.Panel
    Friend WithEvents panDetNetLink As System.Windows.Forms.LinkLabel
    Friend WithEvents panDetBoot As System.Windows.Forms.Panel
    Friend WithEvents panDetBootLink As System.Windows.Forms.LinkLabel
    Friend WithEvents panDetKeys As System.Windows.Forms.Panel
    Friend WithEvents panDetKeysLink As System.Windows.Forms.LinkLabel
    Friend WithEvents panDetSysPic As System.Windows.Forms.PictureBox
    Friend WithEvents panDetNetPic As System.Windows.Forms.PictureBox
    Friend WithEvents panDetBootPic As System.Windows.Forms.PictureBox
    Friend WithEvents panDetKeysPic As System.Windows.Forms.PictureBox
    Friend WithEvents panDetSysCollapse As System.Windows.Forms.Button
    Friend WithEvents panDetNetCollapse As System.Windows.Forms.Button
    Friend WithEvents panDetBootCollapse As System.Windows.Forms.Button
    Friend WithEvents panDetKeysCollapse As System.Windows.Forms.Button
    Friend WithEvents panDetFlowContainer As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents panDetSysControls As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents panDetNetControls As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents panDetBootControls As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents panDetKeysControls As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
End Class
