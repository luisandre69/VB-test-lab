Imports System.Data.SqlClient
Public Class Clientes

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cCliente As New CClientes
        cCliente.CodCliente = txtcodcliente.Text
        cCliente.GetData()
        txtnome.Text = cCliente.Nome
        txtapelido.Text = cCliente.Apelido
        txtmorada.Text = cCliente.Morada
        txttelefone.Text = cCliente.Telefone
        txtcodpostal.Text = cCliente.CodPostal
        txtlocalidade.Text = cCliente.Localidade
        txtobs.Text = cCliente.Obs

        'With Me.ListView1.Items.Add(cCliente.CodCliente)
        '    .SubItems.Add(cCliente.Nome)
        '    .SubItems.Add(cCliente.Apelido)
        'End With

        cCliente = Nothing

        Me.ListView1.Items.Clear()
        SelecionarTodosClientes()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cCliente As New CClientes
        cCliente.UpdateStatus = 1
        cCliente.CodCliente = txtcodcliente.Text
        cCliente.Nome = txtnome.Text
        cCliente.Apelido = txtapelido.Text
        cCliente.Morada = txtmorada.Text
        cCliente.Telefone = txttelefone.Text
        cCliente.CodPostal = txtcodpostal.Text
        cCliente.Localidade = txtlocalidade.Text
        cCliente.Obs = txtobs.Text

        cCliente.SetData()

        cCliente = Nothing

        Me.ListView1.Items.Clear()
        SelecionarTodosClientes()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cCliente As New CClientes
        cCliente.UpdateStatus = 2
        cCliente.CodCliente = txtcodcliente.Text
        cCliente.Nome = txtnome.Text
        cCliente.Apelido = txtapelido.Text
        cCliente.Morada = txtmorada.Text
        cCliente.Telefone = txttelefone.Text
        cCliente.CodPostal = txtcodpostal.Text
        cCliente.Localidade = txtlocalidade.Text
        cCliente.Obs = txtobs.Text

        cCliente.SetData()

        cCliente = Nothing
        Me.ListView1.Items.Clear()
        SelecionarTodosClientes()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cCliente As New CClientes
        cCliente.UpdateStatus = 3
        cCliente.CodCliente = txtcodcliente.Text
        cCliente.Nome = txtnome.Text
        cCliente.Apelido = txtapelido.Text
        cCliente.Morada = txtmorada.Text
        cCliente.Telefone = txttelefone.Text
        cCliente.CodPostal = txtcodpostal.Text
        cCliente.Localidade = txtlocalidade.Text
        cCliente.Obs = txtobs.Text

        cCliente.SetData()

        cCliente = Nothing

        Me.ListView1.Items.Clear()
        SelecionarTodosClientes()

    End Sub
    Sub SelecionarTodosClientes()
        Dim conn As New SqlConnection()
        conn.ConnectionString = "Data Source=10.0.0.120\Teste;Initial Catalog=Pizza;Persist Security Info=True;User ID=sa;password=1.admin"

        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Clientes"
        cmd.Connection = conn

        Dim reader As SqlDataReader
        Dim previousConnectionState As ConnectionState = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            reader = cmd.ExecuteReader()
            Using reader
                While reader.Read
                    ' Process SprocResults datareader here.
                    With Me.ListView1.Items.Add(reader("CodCliente"))
                        .SubItems.Add(reader("Nome"))
                        .SubItems.Add(reader("Apelido"))
                    End With
                End While
            End Using
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SelecionarTodosClientes()
    End Sub
    Sub SelecionarListView()
        Dim conn As New SqlConnection()
        conn.ConnectionString = "Data Source=10.0.0.120\Teste;Initial Catalog=Pizza;Persist Security Info=True;User ID=sa;password=1.admin"

        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Clientes WHERE CodCliente=" & Me.ListView1.SelectedItems(0).Text & ""
        cmd.Connection = conn

        Dim reader As SqlDataReader
        Dim previousConnectionState As ConnectionState = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            reader = cmd.ExecuteReader()
            Using reader
                While reader.Read
                    ' Process SprocResults datareader here.
                    txtcodcliente.Text = reader("CodCliente")
                    txtnome.Text = reader("Nome")
                    txtapelido.Text = reader("Apelido")
                    txtmorada.Text = reader("Morada")
                    txttelefone.Text = reader("Telefone")
                    txtcodpostal.Text = reader("CodPostal")
                    txtlocalidade.Text = reader("Localidade")
                    txtobs.Text = reader("Obs")
                End While
            End Using
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If Me.ListView1.SelectedItems.Count > 0 Then
            SelecionarListView()
        End If
    End Sub
End Class