Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cPessoa1 As New Pessoa
        cPessoa1.Nome = "Pessoa"
        cPessoa1.Apelido = "1"
        MsgBox(cPessoa1.NomeCompleto)

        Dim cPessoa2 As New Pessoa
        cPessoa2.Nome = "Pessoa"
        cPessoa2.Apelido = "2"
        MsgBox(cPessoa2.NomeCompleto)

        Dim cPessoa3 As New Pessoa
        cPessoa3.Nome = "Pessoa"
        cPessoa3.Apelido = "3"
        MsgBox(cPessoa3.NomeCompleto)
    End Sub

    Private Sub btnprocessar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprocessar.Click
        Dim cAluno As New Aluno
        cAluno.Nome = Me.txtNomeAluno.text
        cAluno.Apelido = Me.txtApelidoAluno.text

        cAluno.Notas(0) = Me.txtMat.text
        cAluno.Notas(1) = Me.txtIng.text
        cAluno.Notas(2) = Me.txtFis.text

        cAluno.DataNascimento = CDate(Me.txtDataNascimentoAluno.text)

        MsgBox("Aluno:" & vbCrLf & cAluno.NomeCompleto & " tem " & _
               cAluno.Idade & " anos.")
    End Sub
End Class
