Imports System.Data.SqlClient
Public Class CClientes

    Private _codcliente As Integer
    Private _nome As String
    Private _apelido As String
    Private _morada As String
    Private _telefone As String
    Private _codpostal As String
    Private _localidade As String
    Private _obs As String
    Private _updatestatus As Integer

    Public Property CodCliente() As Integer
        Get
            Return _codcliente
        End Get
        Set(ByVal value As Integer)
            _codcliente = value
        End Set
    End Property

    Public Property Nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property

    Public Property Apelido() As String
        Get
            Return _apelido
        End Get
        Set(ByVal value As String)
            _apelido = value
        End Set
    End Property

    Public Property Morada() As String
        Get
            Return _morada
        End Get
        Set(ByVal value As String)
            _morada = value
        End Set
    End Property

    Public Property Telefone() As String
        Get
            Return _telefone
        End Get
        Set(ByVal value As String)
            _telefone = value
        End Set
    End Property

    Public Property CodPostal() As String
        Get
            Return _codpostal
        End Get
        Set(ByVal value As String)
            _codpostal = value
        End Set
    End Property

    Public Property Localidade() As String
        Get
            Return _localidade
        End Get
        Set(ByVal value As String)
            _localidade = value
        End Set
    End Property

    Public Property Obs() As String
        Get
            Return _obs
        End Get
        Set(ByVal value As String)
            _obs = value
        End Set
    End Property

    Public Property UpdateStatus() As Integer
        Get
            Return _updatestatus
        End Get
        Set(ByVal value As Integer)
            _updatestatus = value
        End Set
    End Property

    Public Sub GetData()
        Dim conn As New SqlConnection()
        conn.ConnectionString = "Data Source=10.0.0.120\Teste;Initial Catalog=Pizza;Persist Security Info=True;User ID=sa;password=1.admin"

        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Clientes WHERE CodCliente = " & CodCliente
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
                    CodCliente = reader("CodCliente")
                    Nome = reader("Nome")
                    Apelido = reader("Apelido")
                    Morada = reader("Morada")
                    Telefone = reader("Telefone")
                    CodPostal = reader("CodPostal")
                    Localidade = reader("Localidade")
                    Obs = reader("Obs")
                End While
            End Using
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub

    Public Sub SetData()
        Dim conn As New SqlConnection()
        conn.ConnectionString = "Data Source=10.0.0.120\Teste;Initial Catalog=Pizza;Persist Security Info=True;User ID=sa;password=1.admin"

        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        Select Case UpdateStatus
            Case 1
                cmd.CommandText = "INSERT INTO Clientes (Nome,Apelido,Morada,CodPostal,Localidade,Obs,Telefone)" & _
                                  "VALUES ('" & Nome & "' , '" & Apelido & "' , '" & Morada & "' , '" & CodPostal & "' , '" & Localidade & "' , '" & Obs & "' , '" & Telefone & "')"
            Case 2
                cmd.CommandText = "UPDATE Clientes SET Nome='" & Nome & "'," & _
                                                    "Apelido='" & Apelido & "'," & _
                                                    "Morada='" & Morada & "'," & _
                                                    "CodPostal='" & CodPostal & "'," & _
                                                    "Localidade='" & Localidade & "'," & _
                                                    "Obs='" & Obs & "'," & _
                                                    "Telefone='" & Telefone & "' " & _
                                                    "WHERE CodCliente=" & CodCliente
            Case 3
                cmd.CommandText = "DELETE FROM Clientes " & _
                                  "WHERE CodCliente=" & CodCliente
        End Select

        cmd.Connection = conn
        ' Create a SqlParameter for each parameter in the stored procedure.
        Dim companyNameParam As New SqlParameter("@companyName", "a%")
        cmd.Parameters.Add(companyNameParam)

        Dim rowCount As Integer
        Dim previousConnectionState As ConnectionState
        previousConnectionState = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            rowCount = cmd.ExecuteNonQuery()

        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
End Class
