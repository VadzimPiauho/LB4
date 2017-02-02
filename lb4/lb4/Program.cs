using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lb4
{
    class Program
    {
        [DllImport("msvcrt")]
        static extern int _getch();

        static void Main(string[] args)
        {
            Storage[] arr = new Storage[3];

            arr[0] = new DVD();
            arr[1] = new Flash();
            arr[2] = new HDD();
            bool go_on = true;           

            while (go_on)
            {
                Console.Clear();
                Console.WriteLine("Выберите имеющийся носитель для копирования 565 ГБ файлов (размер файла 780 Мб)");
                Console.WriteLine("*******************************");
                Console.WriteLine("1 - DVD");
                Console.WriteLine("2 - Flash");
                Console.WriteLine("3 - HDD");
                Console.WriteLine("0 - Выход из программы");
                Console.WriteLine("*******************************");

                switch (_getch())
                {
                    case '1':
                        Console.WriteLine("Введите 1 если диск односторонний 0 двусторонний ");
                        if (Convert.ToString(Console.ReadLine()) == "1")
                        {
                            ((DVD)arr[0]).typeDisk = true;
                        }
                        else
                        {
                            ((DVD)arr[0]).typeDisk = false;
                        }
                        workFunc(((DVD)arr[0]), ref go_on, arr[0].getName());
                        _getch();
                        break;
                    case '2': 
                        Console.WriteLine("Введите объем памяти ");
                        ((Flash) arr[1]).memoryFlash = Convert.ToInt32(Console.ReadLine());
                         workFunc(((Flash)arr[1]), ref go_on, arr[1].getName());
                        _getch();
                        break;
                    case '3':
                        Console.WriteLine("Введите количество разделов ");
                        ((HDD)arr[2]).countSection = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите объем разделов ");
                        ((HDD)arr[2]).memorySection = Convert.ToInt32(Console.ReadLine());
                       // HDD a = arr[2] as HDD;
                        workFunc(((HDD)arr[2]), ref go_on, arr[2].getName());
                        _getch();
                        break;                
                    case '0':
                        go_on = false;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор");
                        Thread.Sleep(1000);
                        break;
                }    
            }
        }
        public static void workFunc(object storage, ref bool go_on, string name)
        {
            
                while (go_on)
                {
                    Console.Clear();
                    Console.WriteLine("Выберите пункт меню");
                    Console.WriteLine("**************************************************************");
                    Console.WriteLine("1 - получение объема памяти");
                    Console.WriteLine("2 - копирование данных (файлов/папок) на устройство");
                    Console.WriteLine("3 - получение информации о свободном объеме памяти на устройстве");
                    Console.WriteLine("4 - получение общей/полной информации об устройстве");
                    Console.WriteLine("0 - Выход из программы");
                    Console.WriteLine("**************************************************************");

                    switch (_getch())
                    {
                        case '1':
                            if (name== "Flash")
                                {
                                ((Flash)storage).amountOFmemory();
                                }
                            if (name == "DVD")
                                {
                                ((DVD)storage).amountOFmemory();
                                 }
                            if (name == "HDD")
                                {
                                ((HDD)storage).amountOFmemory();
                                } 
                        _getch();
                            break;
                        case '2':
                            if (name == "Flash")
                                {
                                ((Flash)storage).copyFile();
                                if (((Flash)storage).memoryFlash<780)
                                    {
                                        Console.WriteLine("Необходим носитель большего объема");
                                        go_on = false;
                                    }
                                }
                            if (name == "DVD")
                                {
                                ((DVD)storage).copyFile();
                                }

                            if (name == "HDD")
                            {
                                ((HDD)storage).copyFile();
                                if (((HDD)storage).countSection * ((HDD)storage).memorySection < 780)
                                {
                                    Console.WriteLine("Необходим носитель большего объема");
                                    go_on = false;
                                }
                            }
                        _getch();
                            break;
                        case '3':
                            if (name == "Flash")
                            {
                                ((Flash)storage).getFreeMemotyDevise();
                            }
                            if (name == "DVD")
                            {
                                ((DVD)storage).getFreeMemotyDevise();
                            }
                            if (name == "HDD")
                            {
                                ((HDD)storage).getFreeMemotyDevise();
                            }
                            _getch();
                            break;
                        case '4':
                                if (name == "Flash")
                                    {
                                        ((Flash)storage).getFullInfoDevise();
                                    }
                                if (name == "DVD")
                                    {
                                        ((DVD)storage).getFullInfoDevise();
                                    }
                                    if (name == "HDD")
                                    {
                                        ((HDD)storage).getFullInfoDevise();
                                    }
                            _getch();
                                break;
                        case '5':

                            _getch();
                            break;
                        case '0':
                            go_on = false;
                            break;
                        default:
                            Console.WriteLine("Неверный выбор");
                            Thread.Sleep(1000);
                            break;
                    }
                }
        }
    }
}
