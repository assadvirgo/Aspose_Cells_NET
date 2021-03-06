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

Namespace Aspose.Cells.Examples.Articles
    Public Class InsertLinkedPicture
        Public Shared Sub Main()
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            'Instantiate a new Workbook.
            Dim workbook As New Workbook()
            'Insert a linked picture (from Web Address) to B2 Cell.
            Dim pic As Global.Aspose.Cells.Drawing.Picture = workbook.Worksheets(0).Shapes.AddLinkedPicture(1, 1, 100, 100, "http://www.aspose.com/Images/aspose-logo.jpg")
            'Set the height and width of the inserted image.
            pic.HeightInch = 1.04
            pic.WidthInch = 2.6
            'Save the Excel file.
            workbook.Save(dataDir & "outLinkedPicture.xlsx")


        End Sub
    End Class
End Namespace