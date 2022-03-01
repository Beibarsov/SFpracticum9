using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    public static string[] SecondNameList;
    static void Main(string[] args)
    {
        SecondNameList = new string[5];
        SecondNameList[0] = "Федорович";
        SecondNameList[1] = "Славянский";
        SecondNameList[2] = "Петров";
        SecondNameList[3] = "Иванов";
        SecondNameList[4] = "Кошкин";

        ArrayReader arrayReader = new ArrayReader();
        arrayReader.ArrayReaderEvent += Sort;
        arrayReader.ArrayReaderEvent += ShowResult;

        try
        {
            arrayReader.InitSort();
        }
        catch (MyException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine($"Введенное значение: {ex.Value}");
            Console.WriteLine($"Подробнее об ошибке можно прочитать: {ex.HelpLink}");
        }


        static void Sort(int variant)
        {
            switch (variant)
            {
                case 1: Array.Sort(SecondNameList); break;
                case 2:
                    {
                        Array.Sort(SecondNameList);
                        Array.Reverse(SecondNameList);
                        break;
                    }


            }
        }
        static void ShowResult(int variant)
        {
            Console.WriteLine("Ниже отображается результат");
            foreach (var item in SecondNameList)
            {
                Console.WriteLine(item);
            }
        }
    }
}


