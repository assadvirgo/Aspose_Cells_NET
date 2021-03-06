//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Cells. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Cells;

namespace Aspose.Cells.Examples.Articles.CreatePivotTablesPivotCharts
{
    public class CreatePivotChart
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            //Instantiating an Workbook object
            //Opening the excel file
            Workbook workbook = new Workbook(dataDir+ "pivotTable_test.xlsx");
            //Adding a new sheet
            Worksheet sheet3 = workbook.Worksheets[workbook.Worksheets.Add(SheetType.Chart)];
            //Naming the sheet
            sheet3.Name = "PivotChart";
            //Adding a column chart
            int index = sheet3.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 0, 5, 28, 16);
            //Setting the pivot chart data source
            sheet3.Charts[index].PivotSource = "PivotTable!PivotTable1";
            sheet3.Charts[index].HidePivotFieldButtons = false;
            //Saving the Excel file
            workbook.Save(dataDir+ "pivotChart_test.xlsx");
            
            
        }
    }
}