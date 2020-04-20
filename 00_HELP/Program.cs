using System;

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main()
        {
            int x = 5;
            int y = 10;

            //извиква се функцията Calcolator в която има Generic делегат clac>, 
            //който препраща към другите методи - за удобство, ако трябва да се прави n-пъти в кода;

            string resultDiv = Calculator(x, y, Divide);
            string resultAdd = Calculator(x, y, Add);
            string resultBiger = Calculator(x, y, IsBigger);

            // може и така, което показва структурата, прехвърлена към подметод (param, pram,...paramN,delegat):
            // вместо функция, може да се подаде ламбда израз: //всички методи по- доло са нещо като наименовани ламбди изрази//

            string resultSubs = Calculator(x, y, (x, y) => (x - y).ToString());


            Console.WriteLine(resultDiv);
            Console.WriteLine(resultAdd);
            Console.WriteLine(resultBiger);
            Console.WriteLine(resultSubs);

            //----- Action<T> -----
            // genereic делегат Action<T> // име- print, тип - string 
            // Action<T> е void - празен не връща ст-т, която да се пази;

            Action<string> print = massage => Console.WriteLine(massage);

            string massage = "Pesho";
            print(massage);

        }

        public static string Calculator(int x, int y, Func<int, int, string> calc)
        {
            //инициализация на делегат с входни параметри -x- -y- и резултат от тип string 
            //този метод Calculator e основен, защото в него е делегата --calc--
            //, който ще прехвърли към друг метод

            return calc(x, y);
        }

        
        public static string Multyply(int x, int y)
        {
            return (x * y).ToString();
        }
        
        public static string Divide(int x, int y)
        {
            return ((double)x / y).ToString();
        }
        public static string Add(int x, int y)
        {
            return (x + y).ToString();
        }
        public static string Subtract(int x, int y)
        {
            return (x - y).ToString();
        }
        public static string IsBigger(int x, int y) => (x > y).ToString(); //съкратен начин - без тяло на функцията, 
        //подходящ за по- кратки методи


        //-------------------------------



    }
}
