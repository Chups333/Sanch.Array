using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Sanch.Array
{
    class Program
    {
        enum Days // перечисление
        {
            Mon, // Mon = 10 - можно менять, а так он 0 -первый 
            Tru,
            Wed,
            Tro,
            Fri,
            Sut,
            Sun
        }

        static void Main(string[] args)
        {
            // одномерный массив
            //int[] array = new int[10]; // массив из 10 чисел
            // array[0] = 1;
            // array[9] = 5;
            // Console.WriteLine(array[9]);
            //Console.ReadKey();

            // двухмерный массив
            //int[,] array = new int[10,10]; // массив из 10*10 чисел
            //array[0,0] = 1;
            //array[9,9] = 5;
            //Console.WriteLine(array[9,9]);
            // Console.ReadKey();

            //Список
            //List<int> list = new List<int>();
            // list.Add(0);
            // list.Add(1);
            // list.Add(2);

            //list[1] = ...

            // enum перечисление
            //Days.
            //Console.WriteLine(Days.Sun); // для улучшения качества кода


            //комментарии в коде
            // - //
            /*
             * 
             * 
             * 
             * 
             */ // Много строк комментов


            /*List<int> list = new List<int>
            {
                1,2,3,4,5,6,7
            };
            */

            //Console.ReadKey();

            //C[] cs = new C[10]; 
            //List<C> css = new List<C>(); из класса
            //int[] array = new int[] { 0, 1, 2 }; сразу назначает
        }
        /*public class C
        {

        }*/
    }
}
