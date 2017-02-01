using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    class Program
    {
        static void Main(string[] args)
        {

            Storage[] arr = new Storage[3];
            DVD arrDVD = new DVD();
            Flash arrFlash = new Flash();
            HDD arrHDD = new HDD();

            arr[1] = arrDVD;
            arr[2] = arrFlash;
            arr[3] = arrHDD;
        }
    }
}
