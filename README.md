# How to get the summary row value from Windows Forms DataGrid(SfDataGrid)	
## About the sample
This example illustrates how to get the summary row value from Windows Forms DataGrid(SfDataGrid)

SfDataGrid allows you, to retrieve the value of summary rows by using the SummaryCreator.GetSummaryDisplayTextForRow() method when GridSummaryRow.ShowSummaryInRow is true.
```c#
 var summary = this.sfDataGrid.View.Records.TableSummaries[0];
 var value = SummaryCreator.GetSummaryDisplayTextForRow(summary, this.sfDataGrid.View);
 MessageBox.Show(value);

```
And you can also retrieve the value of each summary column by using the SummaryCreator.GetSummaryDisplayText() method when GridSummaryRow.ShowSummaryInRow is false.
```c#
 var summary = this.sfDataGrid.View.Records.TableSummaries[0];
 //Retrieves the summary row value of the Quantity column. 
 var value = SummaryCreator.GetSummaryDisplayText(summary, "Quantity", this.sfDataGrid.View);
 MessageBox.Show(value);
```

## Requirements to run the demo
Visual Studio 2015 and above versions
