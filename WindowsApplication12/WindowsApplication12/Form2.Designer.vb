<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblvezes = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblvezes
        '
        Me.lblvezes.AutoSize = True
        Me.lblvezes.Location = New System.Drawing.Point(75, 65)
        Me.lblvezes.Name = "lblvezes"
        Me.lblvezes.Size = New System.Drawing.Size(79, 13)
        Me.lblvezes.TabIndex = 0
        Me.lblvezes.Text = "Falhou 3 vezes"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 143)
        Me.Controls.Add(Me.lblvezes)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblvezes As System.Windows.Forms.Label

End Class
