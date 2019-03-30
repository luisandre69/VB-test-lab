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
        Me.btncalcular = New System.Windows.Forms.Button
        Me.lblvalor1 = New System.Windows.Forms.Label
        Me.lblvalor2 = New System.Windows.Forms.Label
        Me.txtvalor2 = New System.Windows.Forms.TextBox
        Me.txtvalor1 = New System.Windows.Forms.TextBox
        Me.txtoperador = New System.Windows.Forms.ComboBox
        Me.lbloperador = New System.Windows.Forms.Label
        Me.lblResultado = New System.Windows.Forms.Label
        Me.txtresultado = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(42, 172)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 0
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'lblvalor1
        '
        Me.lblvalor1.AutoSize = True
        Me.lblvalor1.Location = New System.Drawing.Point(39, 19)
        Me.lblvalor1.Name = "lblvalor1"
        Me.lblvalor1.Size = New System.Drawing.Size(40, 13)
        Me.lblvalor1.TabIndex = 1
        Me.lblvalor1.Text = "Valor 1"
        '
        'lblvalor2
        '
        Me.lblvalor2.AutoSize = True
        Me.lblvalor2.Location = New System.Drawing.Point(39, 67)
        Me.lblvalor2.Name = "lblvalor2"
        Me.lblvalor2.Size = New System.Drawing.Size(40, 13)
        Me.lblvalor2.TabIndex = 2
        Me.lblvalor2.Text = "Valor 2"
        '
        'txtvalor2
        '
        Me.txtvalor2.Location = New System.Drawing.Point(42, 83)
        Me.txtvalor2.Name = "txtvalor2"
        Me.txtvalor2.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor2.TabIndex = 3
        '
        'txtvalor1
        '
        Me.txtvalor1.Location = New System.Drawing.Point(42, 35)
        Me.txtvalor1.Name = "txtvalor1"
        Me.txtvalor1.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor1.TabIndex = 4
        '
        'txtoperador
        '
        Me.txtoperador.FormattingEnabled = True
        Me.txtoperador.Items.AddRange(New Object() {"+", "-", "*", "/"})
        Me.txtoperador.Location = New System.Drawing.Point(45, 136)
        Me.txtoperador.Name = "txtoperador"
        Me.txtoperador.Size = New System.Drawing.Size(58, 21)
        Me.txtoperador.TabIndex = 5
        '
        'lbloperador
        '
        Me.lbloperador.AutoSize = True
        Me.lbloperador.Location = New System.Drawing.Point(39, 120)
        Me.lbloperador.Name = "lbloperador"
        Me.lbloperador.Size = New System.Drawing.Size(51, 13)
        Me.lbloperador.TabIndex = 6
        Me.lbloperador.Text = "Operador"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(42, 211)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(55, 13)
        Me.lblResultado.TabIndex = 7
        Me.lblResultado.Text = "Resultado"
        '
        'txtresultado
        '
        Me.txtresultado.Location = New System.Drawing.Point(45, 228)
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.Size = New System.Drawing.Size(100, 20)
        Me.txtresultado.TabIndex = 8
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.txtresultado)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lbloperador)
        Me.Controls.Add(Me.txtoperador)
        Me.Controls.Add(Me.txtvalor1)
        Me.Controls.Add(Me.txtvalor2)
        Me.Controls.Add(Me.lblvalor2)
        Me.Controls.Add(Me.lblvalor1)
        Me.Controls.Add(Me.btncalcular)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncalcular As System.Windows.Forms.Button
    Friend WithEvents lblvalor1 As System.Windows.Forms.Label
    Friend WithEvents lblvalor2 As System.Windows.Forms.Label
    Friend WithEvents txtvalor2 As System.Windows.Forms.TextBox
    Friend WithEvents txtvalor1 As System.Windows.Forms.TextBox
    Friend WithEvents txtoperador As System.Windows.Forms.ComboBox
    Friend WithEvents lbloperador As System.Windows.Forms.Label
    Friend WithEvents lblResultado As System.Windows.Forms.Label
    Friend WithEvents txtresultado As System.Windows.Forms.TextBox
End Class
