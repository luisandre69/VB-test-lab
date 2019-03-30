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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbldata = New System.Windows.Forms.Label
        Me.txtdata = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtisdate = New System.Windows.Forms.TextBox
        Me.txtyear = New System.Windows.Forms.TextBox
        Me.txtmonth = New System.Windows.Forms.TextBox
        Me.txtday = New System.Windows.Forms.TextBox
        Me.txtdateadd = New System.Windows.Forms.TextBox
        Me.txtdatepart = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtdataactual = New System.Windows.Forms.TextBox
        Me.btnprocessar = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtdatafinal = New System.Windows.Forms.TextBox
        Me.txthour = New System.Windows.Forms.TextBox
        Me.txtminute = New System.Windows.Forms.TextBox
        Me.txtsecond = New System.Windows.Forms.TextBox
        Me.txtweekday = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lbldata
        '
        Me.lbldata.AutoSize = True
        Me.lbldata.Location = New System.Drawing.Point(13, 13)
        Me.lbldata.Name = "lbldata"
        Me.lbldata.Size = New System.Drawing.Size(30, 13)
        Me.lbldata.TabIndex = 0
        Me.lbldata.Text = "Data"
        '
        'txtdata
        '
        Me.txtdata.Location = New System.Drawing.Point(77, 10)
        Me.txtdata.Name = "txtdata"
        Me.txtdata.Size = New System.Drawing.Size(134, 20)
        Me.txtdata.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "isDate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Month"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Day"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "DateAdd(Year)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "DatePart(Month)"
        '
        'txtisdate
        '
        Me.txtisdate.Location = New System.Drawing.Point(77, 66)
        Me.txtisdate.Name = "txtisdate"
        Me.txtisdate.Size = New System.Drawing.Size(134, 20)
        Me.txtisdate.TabIndex = 8
        '
        'txtyear
        '
        Me.txtyear.Location = New System.Drawing.Point(77, 96)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(134, 20)
        Me.txtyear.TabIndex = 9
        '
        'txtmonth
        '
        Me.txtmonth.Location = New System.Drawing.Point(77, 125)
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.Size = New System.Drawing.Size(134, 20)
        Me.txtmonth.TabIndex = 10
        '
        'txtday
        '
        Me.txtday.Location = New System.Drawing.Point(77, 153)
        Me.txtday.Name = "txtday"
        Me.txtday.Size = New System.Drawing.Size(134, 20)
        Me.txtday.TabIndex = 11
        '
        'txtdateadd
        '
        Me.txtdateadd.Location = New System.Drawing.Point(96, 222)
        Me.txtdateadd.Name = "txtdateadd"
        Me.txtdateadd.Size = New System.Drawing.Size(134, 20)
        Me.txtdateadd.TabIndex = 12
        '
        'txtdatepart
        '
        Me.txtdatepart.Location = New System.Drawing.Point(96, 248)
        Me.txtdatepart.Name = "txtdatepart"
        Me.txtdatepart.Size = New System.Drawing.Size(134, 20)
        Me.txtdatepart.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(318, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Data Actual"
        '
        'txtdataactual
        '
        Me.txtdataactual.Location = New System.Drawing.Point(321, 29)
        Me.txtdataactual.Name = "txtdataactual"
        Me.txtdataactual.Size = New System.Drawing.Size(280, 20)
        Me.txtdataactual.TabIndex = 15
        '
        'btnprocessar
        '
        Me.btnprocessar.Location = New System.Drawing.Point(526, 55)
        Me.btnprocessar.Name = "btnprocessar"
        Me.btnprocessar.Size = New System.Drawing.Size(75, 23)
        Me.btnprocessar.TabIndex = 16
        Me.btnprocessar.Text = "Processar"
        Me.btnprocessar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(318, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Hour"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(318, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Minute"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(318, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Second"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(318, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Weekday"
        '
        'txtdatafinal
        '
        Me.txtdatafinal.Location = New System.Drawing.Point(327, 223)
        Me.txtdatafinal.Name = "txtdatafinal"
        Me.txtdatafinal.Size = New System.Drawing.Size(233, 20)
        Me.txtdatafinal.TabIndex = 21
        '
        'txthour
        '
        Me.txthour.Location = New System.Drawing.Point(374, 82)
        Me.txthour.Name = "txthour"
        Me.txthour.Size = New System.Drawing.Size(132, 20)
        Me.txthour.TabIndex = 22
        '
        'txtminute
        '
        Me.txtminute.Location = New System.Drawing.Point(374, 114)
        Me.txtminute.Name = "txtminute"
        Me.txtminute.Size = New System.Drawing.Size(132, 20)
        Me.txtminute.TabIndex = 23
        '
        'txtsecond
        '
        Me.txtsecond.Location = New System.Drawing.Point(374, 150)
        Me.txtsecond.Name = "txtsecond"
        Me.txtsecond.Size = New System.Drawing.Size(132, 20)
        Me.txtsecond.TabIndex = 24
        '
        'txtweekday
        '
        Me.txtweekday.Location = New System.Drawing.Point(374, 187)
        Me.txtweekday.Name = "txtweekday"
        Me.txtweekday.Size = New System.Drawing.Size(132, 20)
        Me.txtweekday.TabIndex = 25
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 295)
        Me.Controls.Add(Me.txtweekday)
        Me.Controls.Add(Me.txtsecond)
        Me.Controls.Add(Me.txtminute)
        Me.Controls.Add(Me.txthour)
        Me.Controls.Add(Me.txtdatafinal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnprocessar)
        Me.Controls.Add(Me.txtdataactual)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtdatepart)
        Me.Controls.Add(Me.txtdateadd)
        Me.Controls.Add(Me.txtday)
        Me.Controls.Add(Me.txtmonth)
        Me.Controls.Add(Me.txtyear)
        Me.Controls.Add(Me.txtisdate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtdata)
        Me.Controls.Add(Me.lbldata)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Manipulação de Datas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldata As System.Windows.Forms.Label
    Friend WithEvents txtdata As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtisdate As System.Windows.Forms.TextBox
    Friend WithEvents txtyear As System.Windows.Forms.TextBox
    Friend WithEvents txtmonth As System.Windows.Forms.TextBox
    Friend WithEvents txtday As System.Windows.Forms.TextBox
    Friend WithEvents txtdateadd As System.Windows.Forms.TextBox
    Friend WithEvents txtdatepart As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtdataactual As System.Windows.Forms.TextBox
    Friend WithEvents btnprocessar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtdatafinal As System.Windows.Forms.TextBox
    Friend WithEvents txthour As System.Windows.Forms.TextBox
    Friend WithEvents txtminute As System.Windows.Forms.TextBox
    Friend WithEvents txtsecond As System.Windows.Forms.TextBox
    Friend WithEvents txtweekday As System.Windows.Forms.TextBox

End Class
