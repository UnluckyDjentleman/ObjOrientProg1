using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*--------------1-----------------*/
            int N = 5;
            byte bits = 122;
            float f = 6.66f;
            double dd = f;
            object ob=(object)bits;
            bits = 55;
            int? noth=null;
            var v = 32;
            string s = "World";
            //v = 34.45f;//неявно типизированные лок. переменные есть строго типизированные, но тип определяется уже компилятором
            Console.WriteLine(ob);
            Console.WriteLine(bits);
            Console.WriteLine(N);
            Console.WriteLine((int)f);
            Console.WriteLine(dd);
            Console.WriteLine((float)N);
            Console.WriteLine(noth);
            Console.WriteLine(v);
            Console.WriteLine("The last is " + f);
            /*-----------------------2-------------------------*/
            string str0a = null;
            string str0b = "C#";
            Console.WriteLine(str0b == str0a);
            string str1 ="I";
            string str2 ="LOST";
            string str3 ="MYSELF";
            string str3a = String.Copy(str3);
            string str4 = "I want to fit in";
            Console.WriteLine(String.Concat(str1, str2, str3));
            Console.WriteLine(str3a);
            Console.WriteLine(String.Concat(str1, str2, str3).Substring(0,4));
            string[] del = str4.Split(' ');
            foreach(var substr4 in del)
            {
                Console.WriteLine($"{substr4}");
            }
            Console.WriteLine(String.Concat(str1, str2, str3).Insert(5, String.Concat(str1, str2, str3).Substring(0, 2)));
            Console.WriteLine(String.Concat(str1, str2, str3).Replace(String.Concat(str1, str2, str3).Substring(1, 4),""));
            Console.WriteLine($"{str1} am rookie at {str0b}, but I want to become a professional in it!");
            string str5 = "";
            if (String.IsNullOrEmpty(str0a))
            {
                Console.WriteLine($"str0a {str0a} is empty or null");
            }
            else
            {
                Console.WriteLine($"str0a {str0a} is not empty or null");
            }
            if (String.IsNullOrEmpty(str5))
            {
                Console.WriteLine($"str5 {str5} is empty or null");
            }
            else
            {
                Console.WriteLine($"str5 {str5} is not empty or null");
            }
            var sb = new StringBuilder("photophosphorylation");
            sb.Append("red");
            sb.Insert(0, "00000");
            Console.WriteLine(sb);
            sb.Remove(7, 8);
            Console.WriteLine(sb);
            /*--------------------------3-----------------------*/
            double[][] arr = new double[4][];
            arr[0] = new double[2];
            arr[1] = new double[3];
            arr[2] = new double[4];
            for (int i = 0; i < 2; i++)
            {
                arr[0][i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                arr[1][i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                arr[2][i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 2; i++)
            {
                Console.Write(arr[0][i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(arr[1][i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write(arr[2][i] + " ");
            }
            Console.WriteLine();
            int W, L;
            Console.WriteLine("Width: ");
            W = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Length: ");
            L = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[W, L];
            for (int k = 0; k < W; k++)
            {
                for (int l = 0; l < L; l++)
                {
                    Console.WriteLine("Element [" + k + "][" + l + "]: ");
                    mas[k, l] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int k = 0; k < W; k++)
            {
                for (int l = 0; l < L; l++)
                {
                    Console.Write(mas[k, l] + " ");
                }
                Console.WriteLine();
            }
            var stringer = "#@$%";
            var obj = new object[1];
            /*--------------------4-------------------*/
            (int, string, char, string, ulong) cort = (33, s, (char)89, "Minsk", 322290);
            (int, string, char, string, ulong) dot = (57, "Something...", (char)32, "Poland", 485921);
            Console.WriteLine(dot != cort);
            Console.WriteLine(cort.Item1);
            Console.WriteLine(cort.Item3);
            Console.WriteLine(cort.Item4);
            (string, int, int, int, int, int, int)population=(
                           "New York", 7891957, 7781984,
                           7894862, 7071639, 7322564, 8008278);
            Console.WriteLine("Population of {0} in 2000: {1:N0}",
                              population.Item1, population.Item7);
            (int, string) boxer = (1,"Tuple");
            object tuple1 = boxer;
            (int, string) box = ((int, string))tuple1;
            var (_, _, _,points) = statistic("Player");
            Console.WriteLine($"The winner of Hart Trophy has {points} points. He is Name Player from Quebec Nordiques, №64");
            (string name, int goals, int assists, int points) statistic(string name)
            {
                if (name == "Player")
                {
                    return (name, 56, 73, 56+73);
                }
                return ("", 0, 0, 0);
            }
            /*----------------------5---------------------*/
            int[] mat = new int[10];
            for (int i = 0; i < mat.Length; i++)
            {
                Console.WriteLine("Element[" + i + "]:");
                mat[i] = Convert.ToInt16(Console.Read());
            }
            funk(mat, s);
            void funk(int[]array,string str)
            {
                int min = mat[0];
                int max = 0;
                int sum = 0;
                for(int h = 0; h < mat.Length; h++)
                {
                    if (mat[h] < min)
                    {
                        min = mat[h];
                    }
                    else
                    {
                        if (mat[h] > max)
                        {
                            max = mat[h];
                        }
                    }
                    sum = sum+mat[h];
                }
                Console.WriteLine("Max: "+max);
                Console.WriteLine("Min: "+min);
                Console.WriteLine("Sum: "+sum);
                Console.WriteLine("First letter: "+s[0]);
            }
            /*----------------6--------------*/
            int a = int.MaxValue;
            unit(a);
            nit(a);
            void unit(int per)
            {
                unchecked//проверка на переполнение отсутствует
                {
                    Console.WriteLine(per+1);
                }
                try
                {
                    checked
                    {
                        Console.WriteLine(per+1);
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            void nit(int per)
            {
                checked//проверка на переполнение.
                {
                    Console.WriteLine(per+1);
                }
                try
                {
                    unchecked
                    {
                        Console.WriteLine(per+1);
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.Beep();
        }
    }
}
