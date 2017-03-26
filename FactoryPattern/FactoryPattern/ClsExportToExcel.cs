using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ClsExportToExcel : IExport
    {
        public void Export()
        {
            Console.WriteLine("Export to Excel");
        }
    }
}
