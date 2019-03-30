Public Class Form1

    Private Sub btncalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalcular.Click
        Me.txtmedia.Text = (CDbl(Me.txtaluno1.Text) + CDbl(Me.txtaluno2.Text) + CDbl(Me.txtaluno3.Text) + CDbl(Me.txtaluno4.Text) + CDbl(Me.txtaluno5.Text)) / 5
    End Sub
End Class
