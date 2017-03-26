using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ClsFactoryExportCreational
    {
        static public IExport GetExport(int exportType)
        {
            IExport objExport;

            switch (exportType)
            {
                case 1 :
                    objExport = new ClsExportToExcel();
                    break;
                case 2:
                    objExport = new ClsExportToPdf();
                    break;
                default:
                    objExport = new ClsExportToExcel();
                    break;
            }

            return objExport;
        }
    }
}
