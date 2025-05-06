# How can I get notified when a user drops a column into the group drop area

In a WinForms [DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid) to get notified when adds or removes a column in the grouping box area of the SfDataGrid control, you can use the CollectionChanged event of the [GroupColumnDescriptions](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.SfDataGrid.html#Syncfusion_WinForms_DataGrid_SfDataGrid_GroupColumnDescriptions) property.

This event allows you to detect when columns are added or removed from the drop area, as well as identify the action performed.

 
 ```csharp
  private void GroupColumnDescriptions_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
  {
      if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
          // Get the dropped item to GroupDropArea
          var addedItem = e.NewItems[0];
      }

      if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
      {
          // Get the removed item from GroupDropArea
          var removedItem = e.OldItems[0];
      }
  }

 ```
Take a moment to peruse the [Winforms - DataGrid Grouping UG Documentation](https://help.syncfusion.com/windowsforms/datagrid/grouping), to learn more about DataGrid Grouping with examples.