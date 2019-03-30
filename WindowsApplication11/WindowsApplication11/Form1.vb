Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.txtutilizador.Text = Replace(Me.txtutilizador.Text, Space(1), Space(0))
        If InStr(Me.txtemail.Text, "@") < 1 Then
            lblInfoEmail.Text = "Email não está formatado correctamente!"
        Else
            lblInfoEmail.Text = "ok"
        End If
        If Len(Me.txtpalavrapasse.Text) > 7 Then
            lblInfoPalavraPasse1.Text = "ok"
        Else
            lblInfoPalavraPasse1.Text = "Palavra-Passe de ser superior a 7 caracteres!"
        End If
        If Len(Me.txtconfirmarpalavrapasse.Text) > 7 Then
            lblInfoPalavraPasse2.Text = "ok"
        Else
            lblInfoPalavraPasse2.Text = "Confirmação de Palavra-passe de ser superior a 7 caracteres!"
        End If
        If Me.txtpalavrapasse.Text = Me.txtconfirmarpalavrapasse.Text Then
            lblPalavraPasseIgual.Text = "ok"
        Else
            lblPalavraPasseIgual.Text = "A palavra-passe e a sua confirmação devem ser iguais!"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.txtvalor.Text = Me.txtvalor1.Text Then
            lblverifica.Text = "é IGUAL a"
        ElseIf Me.txtvalor.Text < Me.txtvalor1.Text Then
            lblverifica.Text = "é MENOR que"
        Else
            lblverifica.Text = "é MAIOR que"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.txtsalario.Text = CDbl(Me.txtvencimento.Text) + CDbl(Me.txtsubsidio.Text) - CDbl(Me.txtdesconto.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim anos As String
        Dim meses As String
        Dim horas As String
        anos = DateDiff(DateInterval.Year, DateTimePicker1.Value, Now())
        meses = DateDiff(DateInterval.Month, DateTimePicker1.Value, Now())
        horas = DateDiff(DateInterval.Hour, DateTimePicker1.Value, Now())
        lblanos.Text = "Tem" & Space(1) & anos & Space(1) & "anos"
        lblmeses.Text = "Tem" & Space(1) & meses & Space(1) & "meses"
        lblhoras.Text = "Tem" & Space(1) & horas & Space(1) & "horas"
    End Sub
End Class



