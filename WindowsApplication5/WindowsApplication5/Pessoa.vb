
Public Class Pessoa

    Private _apelido As String
    Private _nome As String

    Public Property Apelido() As String
        Get
            Return _apelido
        End Get
        Set(ByVal value As String)
            _apelido = value
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

    Function NomeCompleto() As String
        NomeCompleto = Nome & Space(1) & Apelido

    End Function
End Class
