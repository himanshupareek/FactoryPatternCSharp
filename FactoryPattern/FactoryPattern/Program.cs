using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        //solving mostly two problems :
        //1. Lost of scattered new keyword
        //2. Client is not aware of any invoice types.
        static void Main(string[] args)
        {
            try
            {
                int exportType = 0;
                IExport objExport;

                Console.WriteLine("Enter the export type: ");

                exportType = Convert.ToInt32(Console.ReadLine());

                objExport = ClsFactoryExportCreational.GetExport(exportType);

                objExport.Export();

                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Either you have put a value which is not convertable into integer or there might be some other issue.");
                Console.ReadLine();
            }
            
        }
    }
}
