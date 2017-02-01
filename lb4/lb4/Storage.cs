using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    abstract class Storage
    {
        private string name { get; set; }
        private string model { get; set; }

        public int memory { get; set; } = 565000;
        public int sizeFile { get; set; } = 780;

        public abstract void copyFile();
        public abstract void getFreeMemotyDevise();
        public abstract void getFullInfoDevise();
    }
}
