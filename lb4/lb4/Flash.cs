using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    class Flash : Storage
    {
        public int speedUSB3_0 { get; set; }
        public int memoryFlash { get; set; }
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
