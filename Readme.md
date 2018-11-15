<!-- default file list -->
*Files to look at*:

* [MainViewModel.cs](./CS/dxSampleGrid/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/dxSampleGrid/MainViewModel.vb))
* **[MainWindow.xaml](./CS/dxSampleGrid/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/dxSampleGrid/MainWindow.xaml))**
* [PersonFilteringViewModel.cs](./CS/dxSampleGrid/PersonFilteringViewModel.cs) (VB: [PersonFilteringViewModel.vb](./VB/dxSampleGrid/PersonFilteringViewModel.vb))
<!-- default file list end -->
# How to generate a filter set based on DataLayoutControl


<p>In this example, we use the <strong>FilteringBehavior</strong> class to generate a set of filters based on the metadata type. The metadata type is specified using the <strong>SourceType</strong> property.</p>


```xaml
<dx:FilteringBehavior SourceType="{x:Type local:PersonFilteringViewModel}"/>
```


<p><br>The way properties are edited is configured using the following attributes.<br><br>- <strong>FilterBooleanChoice</strong></p>


```cs
[FilterBooleanChoice()]
public bool HasCar { get; set; }
```


<p> </p>
<p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-generate-a-filter-set-based-on-datalayoutcontrol-t328691/15.2.4+/media/bc757c83-6ad7-11e6-80bf-00155d62480c.png"><br><br>- <strong>FilterDateTimeRange</strong></p>


```cs
[FilterDateTimeRange("MinBirthDate", "MaxBirthDate")]
public DateTime BirthDate { get; set; }
```


<p> </p>
<p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-generate-a-filter-set-based-on-datalayoutcontrol-t328691/15.2.4+/media/2e69f1b7-6ad9-11e6-80bf-00155d62480c.png"><br><br><strong>- FilterRange</strong></p>


```cs
[FilterRange("MinAge", "MaxAge", EditorType = RangeUIEditorType.Range)]
public int Age { get; set; }
```


<p> </p>
<p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-generate-a-filter-set-based-on-datalayoutcontrol-t328691/15.2.4+/media/9a506c11-6ad7-11e6-80bf-00155d62480c.png"><br><br><strong>- FilterLookup</strong></p>


```cs
[FilterLookup("NumberOfChildren")]
public int Children { get; set; }
```


<p> </p>
<p> <img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-generate-a-filter-set-based-on-datalayoutcontrol-t328691/15.2.4+/media/a0df44a3-6ad8-11e6-80bf-00155d62480c.png"><br><br></p>
<p><strong>Important</strong>: In this example, we used the grid's <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.FilterCriteria.property">FilterCriteria</a> property and disabled grid-level filtering. If you want to use <strong>FilteringBehavior</strong> without losing the possibility of filtering data in your grid (using the <a href="https://documentation.devexpress.com/WPF/6133/Controls-and-Libraries/Data-Grid/Filtering-and-Searching/Filter-Dropdown">Filter Dropdown</a>, <a href="https://documentation.devexpress.com/WPF/7788/Controls-and-Libraries/Data-Grid/Filtering-and-Searching/Filter-Editor">Filter Editor</a>, etc.), bind the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfGridDataControlBase_FixedFiltertopic">FixedFilter</a> property instead:</p>


```xaml
<dxg:GridControl ItemsSource="{Binding ListPerson}" AutoGenerateColumns="AddNew" FixedFilter="{Binding Path=FilterCriteria, ElementName=filteringBehavior}">
```



<br/>


