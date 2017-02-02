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
        public double readWriteSpeed { get; } = 1.32;
        public bool typeDisk { get; set; }
        public int memoryDVD1 { get; } = 4700;
        public int memoryDVD2 { get; } = 9000;

        public override void copyFile()
        {
            if (typeDisk)
            {
                Console.WriteLine($"тип диска - односторонний");
                Console.WriteLine($"Необходимо количество носителей DVD равно {(memory / sizeFile) / (memoryDVD1 / sizeFile)}"); ;
            }
            else
            {
                Console.WriteLine($"тип диска - двусторонний");
                Console.WriteLine($"Необходимо количество носителей DVD равно {(memory / sizeFile) / (memoryDVD2 / sizeFile)}");
            }
        }

        public override void getFreeMemotyDevise()
        {
            if (typeDisk)
            {
                Console.WriteLine($"тип диска - односторонний");
                Console.WriteLine($"Cвободный объем памяти на устройстве {((memory / sizeFile) / (memoryDVD1 / sizeFile)) * (memoryDVD1 - (memoryDVD1 / sizeFile) * sizeFile)} Мб");
            }
            else
            {
                Console.WriteLine($"тип диска - двусторонний");
                Console.WriteLine($"Cвободный объем памяти на устройстве {((memory / sizeFile) / (memoryDVD2 / sizeFile)) * (memoryDVD2 - (memoryDVD2 / sizeFile) * sizeFile)} Мб");
            }
        }

        public override void getFullInfoDevise()
        {
            Console.WriteLine($"Наименование носителя - {getName()}");
            Console.WriteLine($"Модель носителя - {getModel()}");
            Console.WriteLine($"скорость записи DVD равна {readWriteSpeed} МБ/с");
            if (typeDisk)
            {
                Console.WriteLine($"тип диска - односторонний");
                Console.WriteLine($"Объем носителя DVD равен {memoryDVD1} МБ");
            }
            else
            {
                Console.WriteLine($"тип диска - двусторонний");
                Console.WriteLine($"Объем носителя DVD равен {memoryDVD2} МБ");
            }
        }

        public override void amountOFmemory()
        {
            if (typeDisk)
            {
                Console.WriteLine($"тип диска - односторонний");
                Console.WriteLine($"Объем памяти DVD равен {memoryDVD1} мб");
            }
            else
            {
                Console.WriteLine($"тип диска - двусторонний");
                Console.WriteLine($"Объем памяти DVD равен {memoryDVD2} мб");
            }            
        }
    }
}
