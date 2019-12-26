<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStdOut
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
        Me.Txt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txt
        '
        Me.Txt.AcceptsReturn = True
        Me.Txt.AcceptsTab = True
        Me.Txt.BackColor = System.Drawing.SystemColors.Control
        Me.Txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Txt.Location = New System.Drawing.Point(0, 0)
        Me.Txt.Multiline = True
        Me.Txt.Name = "Txt"
        Me.Txt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txt.Size = New System.Drawing.Size(596, 323)
        Me.Txt.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(509, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmStdOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 323)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Txt)
        Me.Name = "frmStdOut"
        Me.Text = "PPC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Txt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
