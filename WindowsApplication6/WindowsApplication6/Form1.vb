Public Class Form1

    Private Sub btnboolean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnboolean.Click
        Me.txtresultado.Text = CBool(Me.txtcampoconversao.Text)
    End Sub

    Private Sub btnstring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstring.Click
        Me.txtresultado.Text = CStr(Me.txtcampoconversao.Text)
    End Sub

    Private Sub btndate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndate.Click
        Me.txtresultado.Text = CDate(Me.txtcampoconversao.Text)
    End Sub

    Private Sub btnbyte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbyte.Click
        Me.txtresultado.Text = CByte(Me.txtcampoconversao.Text)
    End Sub

    Private Sub btnsingle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsingle.Click
        Me.txtresultado.Text = CSng(Me.txtcampoconversao.Text)
    End Sub

    Private Sub btnshort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshort.Click
        Me.txtresultado.Text = CShort(Me.txtcampoconversao.Text)
    End Sub

    Private Sub btnlong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlong.Click
        Me.txtresultado.Text = CLng(Me.txtcampoconversao.Text)
    End Sub

    Private Sub btninteger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninteger.Click
        Me.txtresultado.Text = CInt(Me.txtcampoconversao.Text)
    End Sub

    Private Sub btndouble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndouble.Click
        Me.txtresultado.Text = CDbl(Me.txtcampoconversao.Text)
    End Sub

    Private Sub btnDecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecimal.Click
        Me.txtresultado.Text = CDec(Me.txtcampoconversao.Text)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.txtcampoconversao.Text = Space(0)
        Me.txtresultado.Text = Space(0)
    End Sub
End Class
