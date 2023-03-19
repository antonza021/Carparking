using System;
using System.Collections.Generic;
using System.Text;

namespace CarClass
{
    internal class Car
    {
        private string Mark;
        private string Model;
        private string Color;
        private string Number;
        private string Time;
        private int Index;
        public string mark
        {
            get => Mark;
        }
        public string model
        {
            get => Model;
        }
        public string color
        {
            get => Color;
        }
        public string number
        {
            get => Number;
        }
        public string time
        {
            get => Time;
        }
        public int index
        {
            get => Index;
        }


        public Car(string nmark = "No mark", string nmodel = "model", string ncolor = "No color", string nnumber = "No number", string ntime = "No Time", int nindex = 0)
        {
            this.Mark = nmark;
            this.Model = nmodel;
            this.Color = ncolor;
            this.Number = nnumber;
            this.Time = ntime;
            this.Index = nindex;
        }
        public static void SearchCar(ref Car[] array)
        {
            Console.WriteLine("Введите информацию о машине которую хотите найти:");
            string findcar = Console.ReadLine();
            bool found = false;
            bool flag = false;
            int n = 0;
            foreach (var item in array)
            {
                if (item.Mark == findcar || item.Model == findcar || item.Color == findcar || item.Number == findcar)
                {

                    Console.WriteLine($"1. марка: {item.Mark}\n2. модель: {item.Model}\n3. цвет: {item.Color}\n4. номер: {item.Number}\n Это та машина которую вы искали?\n Y - да, любая другая клавиша - нет");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        found = true;
                        n = item.Index;
                        break;
                    }

                    else
                    {
                        flag = true;
                        continue;
                    }
                }
            }

            Console.WriteLine("Удалить машину? Y/N");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Menu.DeleteCar(ref array, n);
                Console.WriteLine(" ");
            }

            if (found == false)
            {
                Console.WriteLine("\n Такой машины не найдено");
                Console.WriteLine(" ");
            }
            if (flag == true)
            {
                Console.WriteLine("\n Больше машин с таким описанием не найдено");
            }
        }
    }
}