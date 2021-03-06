'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Cells. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Aspose.Cells.Examples.Data.AddOn.NamedRanges
    Public Class InputDataInCellsInRange
        Public Shared Sub Main(ByVal args() As String)
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            'Instantiate a new Workbook.
            Dim workbook As New Workbook()

            'Get the first worksheet in the workbook.
            Dim worksheet1 As Worksheet = workbook.Worksheets(0)

            'Create a range of cells based on H1:J4.
            Dim range As Range = worksheet1.Cells.CreateRange("H1", "J4")

            'Name the range.
            range.Name = "MyRange"

            'Input some data into cells in the range.
            range(0, 0).PutValue("USA")
            range(0, 1).PutValue("SA")
            range(0, 2).PutValue("Israel")
            range(1, 0).PutValue("UK")
            range(1, 1).PutValue("AUS")
            range(1, 2).PutValue("Canada")
            range(2, 0).PutValue("France")
            range(2, 1).PutValue("India")
            range(2, 2).PutValue("Egypt")
            range(3, 0).PutValue("China")
            range(3, 1).PutValue("Philipine")
            range(3, 2).PutValue("Brazil")


            'Save the excel file.
            workbook.Save(dataDir & "rangecells.xls")
        End Sub
    End Class
End Namespace