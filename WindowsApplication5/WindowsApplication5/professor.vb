
Public Class Professor
    Inherits Pessoa

    Private _cargo As String

    Public Property cargo() As String
        Get
            Return _cargo
        End Get
        Set(ByVal value As String)
            _cargo = value
        End Set
    End Property
End Class
