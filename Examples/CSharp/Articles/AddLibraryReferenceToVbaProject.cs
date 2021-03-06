﻿using System;
using Aspose.Cells.Vba;

namespace Aspose.Cells.Examples.Articles
{
    class AddLibraryReferenceToVbaProject
    {
        static void Main() {
            string dataDir = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            string outputPath = dataDir + "Output.xlsm";

            Workbook workbook = new Workbook();

            VbaProject vbaProj = workbook.VbaProject;

            vbaProj.References.AddRegisteredReference("stdole", "*\\G{00020430-0000-0000-C000-000000000046}#2.0#0#C:\\Windows\\system32\\stdole2.tlb#OLE Automation");
            vbaProj.References.AddRegisteredReference("Office", "*\\G{2DF8D04C-5BFA-101B-BDE5-00AA0044DE52}#2.0#0#C:\\Program Files\\Common Files\\Microsoft Shared\\OFFICE14\\MSO.DLL#Microsoft Office 14.0 Object Library");

            workbook.Save(outputPath);
        }
    }
}
