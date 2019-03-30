<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnconfirmar = New System.Windows.Forms.Button
        Me.txtpalavrapasse = New System.Windows.Forms.TextBox
        Me.txtutilizador = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Utilizador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Palavra-Passe:"
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Location = New System.Drawing.Point(118, 108)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnconfirmar.TabIndex = 2
        Me.btnconfirmar.Text = "Confirmar"
        Me.btnconfirmar.UseVisualStyleBackColor = True
        '
        'txtpalavrapasse
        '
        Me.txtpalavrapasse.Location = New System.Drawing.Point(109, 64)
        Me.txtpalavrapasse.Name = "txtpalavrapasse"
        Me.txtpalavrapasse.Size = New System.Drawing.Size(100, 20)
        Me.txtpalavrapasse.TabIndex = 3
        '
        'txtutilizador
        '
        Me.txtutilizador.Location = New System.Drawing.Point(109, 25)
        Me.txtutilizador.Name = "txtutilizador"
        Me.txtutilizador.Size = New System.Drawing.Size(100, 20)
        Me.txtutilizador.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 143)
        Me.Controls.Add(Me.txtutilizador)
        Me.Controls.Add(Me.txtpalavrapasse)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents txtpalavrapasse As System.Windows.Forms.TextBox
    Friend WithEvents txtutilizador As System.Windows.Forms.TextBox

End Class
