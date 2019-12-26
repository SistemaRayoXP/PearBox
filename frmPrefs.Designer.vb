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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrefs))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Language")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Paths")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Updates")
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.PathsContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.PathsDefaultPathLabel = New System.Windows.Forms.Label()
        Me.PathsDefaultPath = New System.Windows.Forms.ComboBox()
        Me.PathsRandomMsg = New System.Windows.Forms.CheckBox()
        Me.PathsPPCExecutableLabel = New System.Windows.Forms.Label()
        Me.PathsPPCExecutable = New System.Windows.Forms.ComboBox()
        Me.UpdatesContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.CheckForUpdatesLabel = New System.Windows.Forms.Label()
        Me.Update0 = New System.Windows.Forms.RadioButton()
        Me.Update1 = New System.Windows.Forms.RadioButton()
        Me.Update2 = New System.Windows.Forms.RadioButton()
        Me.Update3 = New System.Windows.Forms.RadioButton()
        Me.LanguageContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SectionPicker = New System.Windows.Forms.ListView()
        Me.Section1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PathsContainer.SuspendLayout()
        Me.UpdatesContainer.SuspendLayout()
        Me.LanguageContainer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Select the path where the new Macs will be saved"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(439, 291)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(520, 291)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'PathsContainer
        '
        Me.PathsContainer.Controls.Add(Me.PathsDefaultPathLabel)
        Me.PathsContainer.Controls.Add(Me.PathsDefaultPath)
        Me.PathsContainer.Controls.Add(Me.PathsRandomMsg)
        Me.PathsContainer.Controls.Add(Me.PathsPPCExecutableLabel)
        Me.PathsContainer.Controls.Add(Me.PathsPPCExecutable)
        Me.PathsContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PathsContainer.Location = New System.Drawing.Point(0, 0)
        Me.PathsContainer.Name = "PathsContainer"
        Me.PathsContainer.Padding = New System.Windows.Forms.Padding(5)
        Me.PathsContainer.Size = New System.Drawing.Size(462, 273)
        Me.PathsContainer.TabIndex = 8
        '
        'PathsDefaultPathLabel
        '
        Me.PathsDefaultPathLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.PathsDefaultPathLabel.Location = New System.Drawing.Point(11, 11)
        Me.PathsDefaultPathLabel.Margin = New System.Windows.Forms.Padding(6, 6, 3, 6)
        Me.PathsDefaultPathLabel.Name = "PathsDefaultPathLabel"
        Me.PathsDefaultPathLabel.Size = New System.Drawing.Size(434, 13)
        Me.PathsDefaultPathLabel.TabIndex = 8
        Me.PathsDefaultPathLabel.Text = "Default location for new Macs:"
        '
        'PathsDefaultPath
        '
        Me.PathsDefaultPath.Dock = System.Windows.Forms.DockStyle.Top
        Me.PathsDefaultPath.FormattingEnabled = True
        Me.PathsDefaultPath.Items.AddRange(New Object() {"Browse..."})
        Me.PathsDefaultPath.Location = New System.Drawing.Point(8, 33)
        Me.PathsDefaultPath.Name = "PathsDefaultPath"
        Me.PathsDefaultPath.Size = New System.Drawing.Size(277, 21)
        Me.PathsDefaultPath.TabIndex = 3
        '
        'PathsRandomMsg
        '
        Me.PathsRandomMsg.AutoSize = True
        Me.PathsRandomMsg.Dock = System.Windows.Forms.DockStyle.Top
        Me.PathsRandomMsg.Location = New System.Drawing.Point(14, 63)
        Me.PathsRandomMsg.Margin = New System.Windows.Forms.Padding(9, 6, 6, 6)
        Me.PathsRandomMsg.Name = "PathsRandomMsg"
        Me.PathsRandomMsg.Size = New System.Drawing.Size(243, 17)
        Me.PathsRandomMsg.TabIndex = 4
        Me.PathsRandomMsg.Text = "Enable random messages in the title of dialogs"
        Me.PathsRandomMsg.UseVisualStyleBackColor = True
        '
        'PathsPPCExecutableLabel
        '
        Me.PathsPPCExecutableLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.PathsPPCExecutableLabel.Location = New System.Drawing.Point(11, 92)
        Me.PathsPPCExecutableLabel.Margin = New System.Windows.Forms.Padding(6, 6, 3, 6)
        Me.PathsPPCExecutableLabel.Name = "PathsPPCExecutableLabel"
        Me.PathsPPCExecutableLabel.Size = New System.Drawing.Size(424, 13)
        Me.PathsPPCExecutableLabel.TabIndex = 9
        Me.PathsPPCExecutableLabel.Text = "PearPC executable path:"
        '
        'PathsPPCExecutable
        '
        Me.PathsPPCExecutable.Dock = System.Windows.Forms.DockStyle.Top
        Me.PathsPPCExecutable.FormattingEnabled = True
        Me.PathsPPCExecutable.Items.AddRange(New Object() {"Browse..."})
        Me.PathsPPCExecutable.Location = New System.Drawing.Point(8, 114)
        Me.PathsPPCExecutable.Name = "PathsPPCExecutable"
        Me.PathsPPCExecutable.Size = New System.Drawing.Size(277, 21)
        Me.PathsPPCExecutable.TabIndex = 10
        '
        'UpdatesContainer
        '
        Me.UpdatesContainer.Controls.Add(Me.CheckForUpdatesLabel)
        Me.UpdatesContainer.Controls.Add(Me.Update0)
        Me.UpdatesContainer.Controls.Add(Me.Update1)
        Me.UpdatesContainer.Controls.Add(Me.Update2)
        Me.UpdatesContainer.Controls.Add(Me.Update3)
        Me.UpdatesContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpdatesContainer.Location = New System.Drawing.Point(0, 0)
        Me.UpdatesContainer.Name = "UpdatesContainer"
        Me.UpdatesContainer.Padding = New System.Windows.Forms.Padding(5)
        Me.UpdatesContainer.Size = New System.Drawing.Size(462, 273)
        Me.UpdatesContainer.TabIndex = 9
        '
        'CheckForUpdatesLabel
        '
        Me.CheckForUpdatesLabel.Location = New System.Drawing.Point(8, 5)
        Me.CheckForUpdatesLabel.Name = "CheckForUpdatesLabel"
        Me.CheckForUpdatesLabel.Size = New System.Drawing.Size(451, 19)
        Me.CheckForUpdatesLabel.TabIndex = 9
        Me.CheckForUpdatesLabel.Text = "Check for updates:"
        '
        'Update0
        '
        Me.Update0.AutoSize = True
        Me.Update0.Checked = True
        Me.Update0.Location = New System.Drawing.Point(8, 27)
        Me.Update0.Name = "Update0"
        Me.Update0.Size = New System.Drawing.Size(54, 17)
        Me.Update0.TabIndex = 8
        Me.Update0.TabStop = True
        Me.Update0.Text = "Never"
        Me.Update0.UseVisualStyleBackColor = True
        '
        'Update1
        '
        Me.Update1.AutoSize = True
        Me.Update1.Location = New System.Drawing.Point(68, 27)
        Me.Update1.Name = "Update1"
        Me.Update1.Size = New System.Drawing.Size(48, 17)
        Me.Update1.TabIndex = 5
        Me.Update1.Text = "Daily"
        Me.Update1.UseVisualStyleBackColor = True
        '
        'Update2
        '
        Me.Update2.AutoSize = True
        Me.Update2.Location = New System.Drawing.Point(122, 27)
        Me.Update2.Name = "Update2"
        Me.Update2.Size = New System.Drawing.Size(61, 17)
        Me.Update2.TabIndex = 6
        Me.Update2.Text = "Weekly"
        Me.Update2.UseVisualStyleBackColor = True
        '
        'Update3
        '
        Me.Update3.AutoSize = True
        Me.Update3.Location = New System.Drawing.Point(189, 27)
        Me.Update3.Name = "Update3"
        Me.Update3.Size = New System.Drawing.Size(62, 17)
        Me.Update3.TabIndex = 7
        Me.Update3.Text = "Monthly"
        Me.Update3.UseVisualStyleBackColor = True
        '
        'LanguageContainer
        '
        Me.LanguageContainer.Controls.Add(Me.Label1)
        Me.LanguageContainer.Controls.Add(Me.ComboBox1)
        Me.LanguageContainer.Controls.Add(Me.Label2)
        Me.LanguageContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LanguageContainer.Location = New System.Drawing.Point(0, 0)
        Me.LanguageContainer.Name = "LanguageContainer"
        Me.LanguageContainer.Padding = New System.Windows.Forms.Padding(5)
        Me.LanguageContainer.Size = New System.Drawing.Size(462, 273)
        Me.LanguageContainer.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Language of the application:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"en-US"})
        Me.ComboBox1.Location = New System.Drawing.Point(155, 8)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(447, 85)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'SectionPicker
        '
        Me.SectionPicker.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Section1})
        Me.SectionPicker.Dock = System.Windows.Forms.DockStyle.Left
        Me.SectionPicker.FullRowSelect = True
        Me.SectionPicker.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.SectionPicker.HideSelection = False
        Me.SectionPicker.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.SectionPicker.Location = New System.Drawing.Point(12, 12)
        Me.SectionPicker.MultiSelect = False
        Me.SectionPicker.Name = "SectionPicker"
        Me.SectionPicker.ShowGroups = False
        Me.SectionPicker.Size = New System.Drawing.Size(121, 302)
        Me.SectionPicker.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.SectionPicker.TabIndex = 2
        Me.SectionPicker.TileSize = New System.Drawing.Size(115, 30)
        Me.SectionPicker.UseCompatibleStateImageBehavior = False
        Me.SectionPicker.View = System.Windows.Forms.View.Details
        '
        'Section1
        '
        Me.Section1.Text = ""
        Me.Section1.Width = 115
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PathsContainer)
        Me.Panel1.Controls.Add(Me.UpdatesContainer)
        Me.Panel1.Controls.Add(Me.LanguageContainer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(133, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(462, 273)
        Me.Panel1.TabIndex = 9
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "*.exe"
        Me.OpenFileDialog1.Filter = "Executables|*.exe|All files|*.*"
        Me.OpenFileDialog1.ReadOnlyChecked = True
        Me.OpenFileDialog1.SupportMultiDottedExtensions = True
        '
        'frmPrefs
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(607, 326)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SectionPicker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPrefs"
        Me.Padding = New System.Windows.Forms.Padding(12)
        Me.Text = "PearBox preferences"
        Me.PathsContainer.ResumeLayout(False)
        Me.PathsContainer.PerformLayout()
        Me.UpdatesContainer.ResumeLayout(False)
        Me.UpdatesContainer.PerformLayout()
        Me.LanguageContainer.ResumeLayout(False)
        Me.LanguageContainer.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents PathsContainer As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PathsDefaultPathLabel As System.Windows.Forms.Label
    Friend WithEvents PathsRandomMsg As System.Windows.Forms.CheckBox
    Friend WithEvents PathsDefaultPath As System.Windows.Forms.ComboBox
    Friend WithEvents UpdatesContainer As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Update1 As System.Windows.Forms.RadioButton
    Friend WithEvents Update2 As System.Windows.Forms.RadioButton
    Friend WithEvents Update3 As System.Windows.Forms.RadioButton
    Friend WithEvents Update0 As System.Windows.Forms.RadioButton
    Friend WithEvents LanguageContainer As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents CheckForUpdatesLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SectionPicker As System.Windows.Forms.ListView
    Friend WithEvents Section1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PathsPPCExecutableLabel As System.Windows.Forms.Label
    Friend WithEvents PathsPPCExecutable As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
