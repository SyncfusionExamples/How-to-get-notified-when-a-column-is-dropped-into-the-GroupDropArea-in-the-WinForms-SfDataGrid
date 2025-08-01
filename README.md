# How to get notified when a column is dropped into the GroupDropArea in the WinForms DataGrid (SfDataGrid)

In [WinForms DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid) (SfDataGrid), to get notified when a column is added or removed in the grouping box area, the `CollectionChanged` event of the [GroupColumnDescriptions](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.SfDataGrid.html#Syncfusion_WinForms_DataGrid_SfDataGrid_GroupColumnDescriptions) property can be used. This event allows for detection when columns are added or removed from the drop area, as well as identification of the action performed.
 
 ```csharp
private void GroupColumnDescriptions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
{
    if (e.Action == NotifyCollectionChangedAction.Add)
    {
        // Get the dropped item to GroupDropArea
        var addedItem = e.NewItems[0];
    }

    if (e.Action == NotifyCollectionChangedAction.Remove)
    {
        // Get the removed item from GroupDropArea
        var removedItem = e.OldItems[0];
    }
}
 ```
Take a moment to peruse the [WinForms DataGrid - Grouping](https://help.syncfusion.com/windowsforms/datagrid/grouping) documentation, where you can find about the grouping with code examples.