Imports System
Imports System.Collections.ObjectModel
Imports System.Linq

Namespace dxSampleGrid
    Public Class MainViewModel
        Public Sub New()
            CreateList()
            CalculateFilterProperties()
        End Sub

        Private Sub CalculateFilterProperties()
            NumberOfChildren = New Integer() { 0, 1, 2, 3 }

            MinAge = ListPerson.Min(Function(x) x.Age)
            MaxAge = ListPerson.Max(Function(x) x.Age)

            MinBirthDate = ListPerson.Min(Function(x) x.BirthDate)
            MaxBirthDate = ListPerson.Max(Function(x) x.BirthDate)
        End Sub

        Private Sub CreateList()
            ListPerson = New ObservableCollection(Of Person)()
            For i As Integer = 0 To 9
                ListPerson.Add(New Person(i))
            Next i
        End Sub

        Public Property ListPerson() As ObservableCollection(Of Person)
        Public Property MaxAge() As Integer
        Public Property MinAge() As Integer
        Public Property MaxBirthDate() As Date
        Public Property MinBirthDate() As Date
        Public Property NumberOfChildren() As Integer()
    End Class
End Namespace