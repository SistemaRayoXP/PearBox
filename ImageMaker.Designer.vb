<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageMaker
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Progress = New System.Windows.Forms.ProgressBar()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.ProgressLabel = New System.Windows.Forms.Label()
        Me.DiskMakerProcess = New System.ComponentModel.BackgroundWorker()
        Me.Status = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdCancel, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(347, 59)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(76, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        Me.TableLayoutPanel1.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(4, 3)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(67, 23)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "Cancel"
        '
        'Progress
        '
        Me.Progress.Location = New System.Drawing.Point(12, 12)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(411, 23)
        Me.Progress.TabIndex = 1
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Location = New System.Drawing.Point(12, 67)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(51, 13)
        Me.StatusLabel.TabIndex = 2
        Me.StatusLabel.Text = "Progress:"
        '
        'ProgressLabel
        '
        Me.ProgressLabel.AutoSize = True
        Me.ProgressLabel.Location = New System.Drawing.Point(204, 38)
        Me.ProgressLabel.Name = "ProgressLabel"
        Me.ProgressLabel.Size = New System.Drawing.Size(21, 13)
        Me.ProgressLabel.TabIndex = 3
        Me.ProgressLabel.Text = "0%"
        Me.ProgressLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DiskMakerProcess
        '
        Me.DiskMakerProcess.WorkerSupportsCancellation = True
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Location = New System.Drawing.Point(69, 67)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(0, 13)
        Me.Status.TabIndex = 5
        '
        'ImageMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 100)
        Me.ControlBox = False
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.ProgressLabel)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ImageMaker"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Creating disk image..."
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents Progress As System.Windows.Forms.ProgressBar
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents ProgressLabel As System.Windows.Forms.Label
    Friend WithEvents DiskMakerProcess As System.ComponentModel.BackgroundWorker
    Friend WithEvents Status As System.Windows.Forms.Label

End Class
