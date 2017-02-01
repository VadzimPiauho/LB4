using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    class HDD : Storage
    {
        public int speedUSB2_0 { get; set; }
        public int memorySection { get; set;}
        public int countSection { get; set; }
        public override void copyFile()
        {
            throw new NotImplementedException();
        }

        public override void getFreeMemotyDevise()
        {
            throw new NotImplementedException();
        }

        public override void getFullInfoDevise()
        {
            throw new NotImplementedException();
        }
    }
}
