
Public Class Aluno
    Inherits Pessoa

    Private _datanascimento As DateTime
    Private _iniciais As String
    Private _notas(2) As Integer

    Public Property DataNascimento() As Date
        Get
            Return _datanascimento
        End Get
        Set(ByVal value As Date)
            _datanascimento = value
        End Set
    End Property

    Public Property Notas(ByVal intNotas As Integer) As Double
        Get
            Return _notas(intNotas)
        End Get
        Set(ByVal value As Double)
            _notas(intNotas) = value
        End Set
    End Property

    Public Function Idade() As String
        Idade = DateDiff(DateInterval.Year, DataNascimento, Now())
    End Function
End Class
