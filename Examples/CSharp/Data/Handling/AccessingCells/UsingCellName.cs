//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Cells. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Cells;
using System;

namespace Aspose.Cells.Examples.Data.Handling.AccessingCells
{
    public class UsingCellName
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            Workbook workbook = new Workbook(dataDir + "book1.xls");

            //Using the Sheet 1 in Workbook
            Worksheet worksheet = workbook.Worksheets[0];

            //Accessing a cell using its name
            Cell cell = worksheet.Cells["A1"];

            string value = cell.Value.ToString();

            Console.WriteLine(value);
        }
    }
}