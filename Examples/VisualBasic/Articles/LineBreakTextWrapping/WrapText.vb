'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Cells. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Aspose.Cells.Examples.Articles.LineBreakTextWrapping
    Public Class WrapText
        Public Shared Sub Main()
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            'Create Workbook Object
            Dim wb As New Workbook()

            'Open first Worksheet in the workbook
            Dim ws As Worksheet = wb.Worksheets(0)

            'Get Worksheet Cells Collection
            Dim cell As Global.Aspose.Cells.Cells = ws.Cells

            'Increase the width of First Column Width
            cell.SetColumnWidth(0, 35)

            'Increase the height of first row
            cell.SetRowHeight(0, 36)

            'Add Text to the Firts Cell
            cell(0, 0).PutValue("I am using the latest version of Aspose.Cells to test this functionality")

            'Make Cell's Text wrap
            Dim style As Style = cell(0, 0).GetStyle()
            style.IsTextWrapped = True
            cell(0, 0).SetStyle(style)

            ' Save Excel File
            wb.Save(dataDir & "WrappingText.xlsx")


        End Sub
    End Class
End Namespace