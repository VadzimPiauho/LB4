using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    abstract class Storage
    {
        private string name { get;}
        private string model { get;}
        public int memory { get;} = 565000;
        public int sizeFile { get; } = 780;

        public Storage(string name, string model)
        {
            this.name = name;
            this.model = model;
        }

        public virtual string getName()
        {
            return name;
        }
        public virtual string getModel()
        {
            return model;
        }

        public abstract void amountOFmemory();
        public abstract void copyFile();
        public abstract void getFreeMemotyDevise();
        public abstract void getFullInfoDevise();
    }
}
