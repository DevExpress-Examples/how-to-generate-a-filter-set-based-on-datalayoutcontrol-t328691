Imports System
Imports System.Linq

Namespace dxSampleGrid
    Public Class Person
        Public Sub New(ByVal i As Integer)
            FirstName = "FirstName" & i
            Age = i * 10
            HasCar = i Mod 2 = 0
            Children = i Mod 4
            BirthDate = (New Date(2010, 1, 1)).AddDays(i)
        End Sub

        Public Property Age() As Integer
        Public Property BirthDate() As Date
        Public Property Children() As Integer
        Public Property FirstName() As String
        Public Property HasCar() As Boolean
    End Class
End Namespace