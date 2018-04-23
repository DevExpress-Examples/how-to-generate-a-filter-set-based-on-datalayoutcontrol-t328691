Imports DevExpress.Utils.Filtering
Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.Linq

Namespace dxSampleGrid
    Public Class PersonFilteringViewModel
        <Display(Name := "Age"), FilterRange("MinAge", "MaxAge", EditorType := RangeUIEditorType.Range)> _
        Public Property Age() As Integer

        <Display(Name := "Children"), FilterLookup("NumberOfChildren")> _
        Public Property Children() As Integer

        <Display(Name := "HasCar"), FilterBooleanChoice()> _
        Public Property HasCar() As Boolean

        <Display(Name := "BirthDate"), FilterDateTimeRange("MinBirthDate", "MaxBirthDate")> _
        Public Property BirthDate() As Date
    End Class
End Namespace