#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Styles;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.Data;

namespace GettingStarted
{   
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            var data = new OrderInfoCollection();
            sfDataGrid.DataSource = data.OrdersListDetails;

            GridTableSummaryRow tableSummaryRow1 = new GridTableSummaryRow();
            tableSummaryRow1.Name = "TableSummary";
            tableSummaryRow1.ShowSummaryInRow = false;
            tableSummaryRow1.Title = " Total Product Count: {OrderID}";
            tableSummaryRow1.Position = VerticalPosition.Bottom;

            GridSummaryColumn summaryColumn1 = new GridSummaryColumn();
            summaryColumn1.Name = "OrderID";
            summaryColumn1.SummaryType = SummaryType.CountAggregate;
            summaryColumn1.Format = "{Count}";
            summaryColumn1.MappingName = "OrderID";

            GridSummaryColumn summaryColumn2 = new GridSummaryColumn();
            summaryColumn2.Name = "Quantity";
            summaryColumn2.SummaryType = SummaryType.Int32Aggregate;
            summaryColumn2.Format = "{Sum}";
            summaryColumn2.MappingName = "Quantity";

            tableSummaryRow1.SummaryColumns.Add(summaryColumn1);
            tableSummaryRow1.SummaryColumns.Add(summaryColumn2);

            this.sfDataGrid.TableSummaryRows.Add(tableSummaryRow1);
        }

        #endregion 

        private void button1_Click(object sender, System.EventArgs e)
        {
            //var summary = this.sfDataGrid.View.Records.TableSummaries[0];
            //var value = SummaryCreator.GetSummaryDisplayTextForRow(summary, this.sfDataGrid.View);
            //MessageBox.Show(value);

            var summary = this.sfDataGrid.View.Records.TableSummaries[0];
            //Retrieves the summary row value of the Quantity column. 
            var value = SummaryCreator.GetSummaryDisplayText(summary, "Quantity", this.sfDataGrid.View);
            MessageBox.Show(value);
        }
    }
}
