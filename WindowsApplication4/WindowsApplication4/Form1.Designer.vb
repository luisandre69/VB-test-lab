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
        Me.lblaluno1 = New System.Windows.Forms.Label
        Me.lblaluno2 = New System.Windows.Forms.Label
        Me.lblaluno3 = New System.Windows.Forms.Label
        Me.lblaluno4 = New System.Windows.Forms.Label
        Me.lblaluno5 = New System.Windows.Forms.Label
        Me.txtaluno1 = New System.Windows.Forms.TextBox
        Me.txtaluno2 = New System.Windows.Forms.TextBox
        Me.txtaluno3 = New System.Windows.Forms.TextBox
        Me.txtaluno4 = New System.Windows.Forms.TextBox
        Me.txtaluno5 = New System.Windows.Forms.TextBox
        Me.btncalcular = New System.Windows.Forms.Button
        Me.txtmedia = New System.Windows.Forms.TextBox
        Me.lblmedia = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblaluno1
        '
        Me.lblaluno1.AutoSize = True
        Me.lblaluno1.Location = New System.Drawing.Point(81, 23)
        Me.lblaluno1.Name = "lblaluno1"
        Me.lblaluno1.Size = New System.Drawing.Size(43, 13)
        Me.lblaluno1.TabIndex = 0
        Me.lblaluno1.Text = "Aluno 1"
        '
        'lblaluno2
        '
        Me.lblaluno2.AutoSize = True
        Me.lblaluno2.Location = New System.Drawing.Point(81, 52)
        Me.lblaluno2.Name = "lblaluno2"
        Me.lblaluno2.Size = New System.Drawing.Size(43, 13)
        Me.lblaluno2.TabIndex = 1
        Me.lblaluno2.Text = "Aluno 2"
        '
        'lblaluno3
        '
        Me.lblaluno3.AutoSize = True
        Me.lblaluno3.Location = New System.Drawing.Point(81, 78)
        Me.lblaluno3.Name = "lblaluno3"
        Me.lblaluno3.Size = New System.Drawing.Size(43, 13)
        Me.lblaluno3.TabIndex = 2
        Me.lblaluno3.Text = "Aluno 3"
        '
        'lblaluno4
        '
        Me.lblaluno4.AutoSize = True
        Me.lblaluno4.Location = New System.Drawing.Point(81, 104)
        Me.lblaluno4.Name = "lblaluno4"
        Me.lblaluno4.Size = New System.Drawing.Size(43, 13)
        Me.lblaluno4.TabIndex = 3
        Me.lblaluno4.Text = "Aluno 4"
        '
        'lblaluno5
        '
        Me.lblaluno5.AutoSize = True
        Me.lblaluno5.Location = New System.Drawing.Point(81, 130)
        Me.lblaluno5.Name = "lblaluno5"
        Me.lblaluno5.Size = New System.Drawing.Size(43, 13)
        Me.lblaluno5.TabIndex = 4
        Me.lblaluno5.Text = "Aluno 5"
        '
        'txtaluno1
        '
        Me.txtaluno1.Location = New System.Drawing.Point(126, 23)
        Me.txtaluno1.Name = "txtaluno1"
        Me.txtaluno1.Size = New System.Drawing.Size(100, 20)
        Me.txtaluno1.TabIndex = 5
        '
        'txtaluno2
        '
        Me.txtaluno2.Location = New System.Drawing.Point(126, 49)
        Me.txtaluno2.Name = "txtaluno2"
        Me.txtaluno2.Size = New System.Drawing.Size(100, 20)
        Me.txtaluno2.TabIndex = 6
        '
        'txtaluno3
        '
        Me.txtaluno3.Location = New System.Drawing.Point(126, 75)
        Me.txtaluno3.Name = "txtaluno3"
        Me.txtaluno3.Size = New System.Drawing.Size(100, 20)
        Me.txtaluno3.TabIndex = 7
        '
        'txtaluno4
        '
        Me.txtaluno4.Location = New System.Drawing.Point(126, 101)
        Me.txtaluno4.Name = "txtaluno4"
        Me.txtaluno4.Size = New System.Drawing.Size(100, 20)
        Me.txtaluno4.TabIndex = 8
        '
        'txtaluno5
        '
        Me.txtaluno5.Location = New System.Drawing.Point(126, 127)
        Me.txtaluno5.Name = "txtaluno5"
        Me.txtaluno5.Size = New System.Drawing.Size(100, 20)
        Me.txtaluno5.TabIndex = 9
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(239, 195)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 10
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'txtmedia
        '
        Me.txtmedia.Location = New System.Drawing.Point(126, 166)
        Me.txtmedia.Name = "txtmedia"
        Me.txtmedia.Size = New System.Drawing.Size(100, 20)
        Me.txtmedia.TabIndex = 11
        '
        'lblmedia
        '
        Me.lblmedia.AutoSize = True
        Me.lblmedia.Location = New System.Drawing.Point(154, 150)
        Me.lblmedia.Name = "lblmedia"
        Me.lblmedia.Size = New System.Drawing.Size(36, 13)
        Me.lblmedia.TabIndex = 12
        Me.lblmedia.Text = "Média"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 230)
        Me.Controls.Add(Me.lblmedia)
        Me.Controls.Add(Me.txtmedia)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtaluno5)
        Me.Controls.Add(Me.txtaluno4)
        Me.Controls.Add(Me.txtaluno3)
        Me.Controls.Add(Me.txtaluno2)
        Me.Controls.Add(Me.txtaluno1)
        Me.Controls.Add(Me.lblaluno5)
        Me.Controls.Add(Me.lblaluno4)
        Me.Controls.Add(Me.lblaluno3)
        Me.Controls.Add(Me.lblaluno2)
        Me.Controls.Add(Me.lblaluno1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblaluno1 As System.Windows.Forms.Label
    Friend WithEvents lblaluno2 As System.Windows.Forms.Label
    Friend WithEvents lblaluno3 As System.Windows.Forms.Label
    Friend WithEvents lblaluno4 As System.Windows.Forms.Label
    Friend WithEvents lblaluno5 As System.Windows.Forms.Label
    Friend WithEvents txtaluno1 As System.Windows.Forms.TextBox
    Friend WithEvents txtaluno2 As System.Windows.Forms.TextBox
    Friend WithEvents txtaluno3 As System.Windows.Forms.TextBox
    Friend WithEvents txtaluno4 As System.Windows.Forms.TextBox
    Friend WithEvents txtaluno5 As System.Windows.Forms.TextBox
    Friend WithEvents btncalcular As System.Windows.Forms.Button
    Friend WithEvents txtmedia As System.Windows.Forms.TextBox
    Friend WithEvents lblmedia As System.Windows.Forms.Label

End Class
