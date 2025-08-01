using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid;

namespace WinformsDataGrid
{
    public partial class Form1 : Form
    {
        OrderInfoCollection orderInfoCollection;

        public Form1()
        {
            InitializeComponent();

            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "OrderID", HeaderText = "Order ID" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerName", Width = 150, HeaderText = "Customer Name" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "Country", HeaderText = "Country" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipCity", HeaderText = "Ship City" });
            orderInfoCollection = new OrderInfoCollection();
            sfDataGrid1.DataSource = orderInfoCollection.Orders;
            sfDataGrid1.ShowGroupDropArea = true;
            //Event subscription
            sfDataGrid1.GroupColumnDescriptions.CollectionChanged += GroupColumnDescriptions_CollectionChanged;
        }

        //Event customization
        private void GroupColumnDescriptions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
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
    }
}
