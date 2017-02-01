using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    class Flash : Storage
    {
        public int speedUSB3_0 { get; } = 5000;
        public int memoryFlash { get; set; }
        public Flash() : base("Flash", "память") { }
        public override void copyFile()
        {
            if (memoryFlash < sizeFile)
            {
                Console.WriteLine($"Корректно перенести информацию не получится т.к. размер флешки меньше размера файла");
                return;
            }
            if (memoryFlash > memory)
            {
                Console.WriteLine($"Необходимо количество носителей Flash равно 1");
            }
            else
            {
                Console.WriteLine($"Необходимо количество носителей Flash равно {(memory / sizeFile) / (memoryFlash / sizeFile)}");
            }    
        }

        public override void getFreeMemotyDevise()
        {
            if (memoryFlash > memory)
            {
                Console.WriteLine($"Cвободный объем памяти на устройстве {memoryFlash- memory}");
            }
            else
            {
                Console.WriteLine($"Cвободный объем памяти на устройстве {((memory / sizeFile) / (memoryFlash / sizeFile)) * (memoryFlash-(memoryFlash / sizeFile)* sizeFile)}");
            }
            
        }

        public override void getFullInfoDevise()
        {
            Console.WriteLine($"Наименование носителя - {getName()}");
            Console.WriteLine($"Модель носителя - {getModel()}");
            Console.WriteLine($"Объем носителя Flash равен {memoryFlash} МБ");
            Console.WriteLine($"скорость USB 3.0 равна {speedUSB3_0} МБ/с");
        }

        public override void amountOFmemory()
        {
            Console.WriteLine($"Объем носителя Flash равен {memoryFlash} МБ");
        }
    }
}
