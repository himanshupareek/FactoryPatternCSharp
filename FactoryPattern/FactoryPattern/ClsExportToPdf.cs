﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ClsExportToPdf : IExport
    {
        public void Export()
        {
            Console.WriteLine("Export to PDF");
        }
    }
}
