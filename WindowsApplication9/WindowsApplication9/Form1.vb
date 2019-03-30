Public Class Form1

    Private Sub txtisdate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtisdate.TextChanged

    End Sub

    Private Sub txtdataactual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdataactual.TextChanged

    End Sub

    Private Sub btnprocessar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprocessar.Click
        Me.txtdataactual.Text = Now()
        Me.txtisdate.Text = IsDate(Me.txtdata.Text)
        Me.txtyear.Text = Year(Me.txtdata.Text)
        Me.txtmonth.Text = Month(Me.txtdata.Text)
        Me.txtday.Text = Microsoft.VisualBasic.DateAndTime.Day(Me.txtdata.Text)
        Me.txthour.Text = Hour(Me.txtdata.Text)
        Me.txtminute.Text = Minute(Me.txtdata.Text)
        Me.txtsecond.Text = Second(Me.txtdata.Text)
        Me.txtweekday.Text = Weekday(Me.txtdata.Text)
        Me.txtdatafinal.Text = DateAdd(DateInterval.Year, CInt(Me.txtdateadd.Text), CDate(Me.txtdata.Text))
        Me.txtdatepart.Text = DatePart(DateInterval.Month, CDate(Me.txtdata.Text))
    End Sub
End Class
