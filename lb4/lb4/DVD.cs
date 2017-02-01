using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    class DVD : Storage
    {
        public DVD() : base("DVD", "диск") { }
        public int readWriteSpeed { get; set; }
        public bool typeDisk { get; set; }
        public int memoryDVD { get; set; }

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

        public override void amountOFmemory()
        {
            Console.WriteLine($"Объем памяти DVD равен {memoryDVD}");
        }
    }
}
