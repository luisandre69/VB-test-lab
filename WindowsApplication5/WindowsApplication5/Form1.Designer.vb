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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNomeAluno = New System.Windows.Forms.TextBox
        Me.txtApelidoAluno = New System.Windows.Forms.TextBox
        Me.txtDataNascimentoAluno = New System.Windows.Forms.TextBox
        Me.txtMat = New System.Windows.Forms.TextBox
        Me.txtIng = New System.Windows.Forms.TextBox
        Me.txtFis = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnprocessar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(336, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apelido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Data Nascimento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(300, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Matemática:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(300, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Inglês:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(301, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Física:"
        '
        'txtNomeAluno
        '
        Me.txtNomeAluno.Location = New System.Drawing.Point(103, 37)
        Me.txtNomeAluno.Name = "txtNomeAluno"
        Me.txtNomeAluno.Size = New System.Drawing.Size(161, 20)
        Me.txtNomeAluno.TabIndex = 7
        '
        'txtApelidoAluno
        '
        Me.txtApelidoAluno.Location = New System.Drawing.Point(103, 63)
        Me.txtApelidoAluno.Name = "txtApelidoAluno"
        Me.txtApelidoAluno.Size = New System.Drawing.Size(161, 20)
        Me.txtApelidoAluno.TabIndex = 8
        '
        'txtDataNascimentoAluno
        '
        Me.txtDataNascimentoAluno.Location = New System.Drawing.Point(103, 91)
        Me.txtDataNascimentoAluno.Name = "txtDataNascimentoAluno"
        Me.txtDataNascimentoAluno.Size = New System.Drawing.Size(161, 20)
        Me.txtDataNascimentoAluno.TabIndex = 9
        '
        'txtMat
        '
        Me.txtMat.Location = New System.Drawing.Point(365, 33)
        Me.txtMat.Name = "txtMat"
        Me.txtMat.Size = New System.Drawing.Size(46, 20)
        Me.txtMat.TabIndex = 10
        '
        'txtIng
        '
        Me.txtIng.Location = New System.Drawing.Point(365, 60)
        Me.txtIng.Name = "txtIng"
        Me.txtIng.Size = New System.Drawing.Size(46, 20)
        Me.txtIng.TabIndex = 11
        '
        'txtFis
        '
        Me.txtFis.Location = New System.Drawing.Point(365, 86)
        Me.txtFis.Name = "txtFis"
        Me.txtFis.Size = New System.Drawing.Size(46, 20)
        Me.txtFis.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Aluno:"
        '
        'btnprocessar
        '
        Me.btnprocessar.Location = New System.Drawing.Point(336, 162)
        Me.btnprocessar.Name = "btnprocessar"
        Me.btnprocessar.Size = New System.Drawing.Size(75, 23)
        Me.btnprocessar.TabIndex = 14
        Me.btnprocessar.Text = "Processar"
        Me.btnprocessar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 229)
        Me.Controls.Add(Me.btnprocessar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtFis)
        Me.Controls.Add(Me.txtIng)
        Me.Controls.Add(Me.txtMat)
        Me.Controls.Add(Me.txtDataNascimentoAluno)
        Me.Controls.Add(Me.txtApelidoAluno)
        Me.Controls.Add(Me.txtNomeAluno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNomeAluno As System.Windows.Forms.TextBox
    Friend WithEvents txtApelidoAluno As System.Windows.Forms.TextBox
    Friend WithEvents txtDataNascimentoAluno As System.Windows.Forms.TextBox
    Friend WithEvents txtMat As System.Windows.Forms.TextBox
    Friend WithEvents txtIng As System.Windows.Forms.TextBox
    Friend WithEvents txtFis As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnprocessar As System.Windows.Forms.Button

End Class
