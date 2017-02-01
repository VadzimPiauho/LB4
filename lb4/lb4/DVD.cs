using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    class DVD : Storage
    {
        public int readWriteSpeed { get; set; }
        public string typeDisk { get; set; } 

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
