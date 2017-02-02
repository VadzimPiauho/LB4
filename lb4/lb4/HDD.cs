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
        public HDD() : base("HDD", "съемный ") { }
        public override void copyFile()
        {
            if (countSection* memorySection < sizeFile)
            {
                Console.WriteLine($"Корректно перенести информацию не получится т.к. размер флешки меньше размера файла");
                return;
            }
            if (countSection * memorySection > memory)
            {
                Console.WriteLine($"Необходимо количество носителей Flash равно 1");
            }
            else
            {
                Console.WriteLine($"Необходимо количество носителей Flash равно {(memory / sizeFile) / (countSection * memorySection / sizeFile)}");
            }
        }

        public override void getFreeMemotyDevise()
        {
            if (countSection * memorySection > memory)
            {
                Console.WriteLine($"Cвободный объем памяти на устройстве/вах  {countSection * memorySection - memory} Мб");
            }
            else
            {
                Console.WriteLine($"Cвободный объем памяти на устройстве {((memory / sizeFile) / (countSection * memorySection / sizeFile)) * (countSection * memorySection - (countSection * memorySection / sizeFile) * sizeFile)}");
            }
        }

        public override void getFullInfoDevise()
        {
            Console.WriteLine($"Наименование носителя - {getName()}");
            Console.WriteLine($"Модель носителя - {getModel()}");
            Console.WriteLine($"Объем носителя Flash равен {memorySection * countSection} МБ");
            Console.WriteLine($"скорость USB 2.0 равна {speedUSB2_0} МБ/с");
        }

        public override void amountOFmemory()
        {
            Console.WriteLine($"Объем носителя HDD равен {memorySection * countSection} МБ");
        }
    }
}
