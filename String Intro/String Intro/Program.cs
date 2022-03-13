using System;

namespace String_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stringintro
            //int a = 15;
            //int b = a;
            //b = 10;
            //Console.WriteLine(b);


            //string word = "hello";
            //string word2 = word;
            //word2 = "world";
            //Console.WriteLine(word);
            //string word3 = "world";
            //word3 += "s";
            //Console.WriteLine(word3);
            //Console.WriteLine(word2 == word3);
            //int[] arr = { 13,20,15};
            //int[] arr1 = { 13, 20, 15 };
            //Console.WriteLine(arr==arr1);



            //string a = "    HelLo  world     ";
            //Console.WriteLine(a.Length);
            //Console.WriteLine(a.ToLower());
            //Console.WriteLine(a.ToUpper());
            //Console.WriteLine(a.Equals("Hello world"));
            //Console.WriteLine(a.Trim());
            //Console.WriteLine(a.TrimEnd());
            //Console.WriteLine(a.ToLower().Contains("w".ToLower()));
            //Console.WriteLine(a.Replace(" ", "--"));
            //Console.WriteLine(string.Concat(a,"Salam"));
            //Console.WriteLine(a.IndexOf("w"));
            //Console.WriteLine(a.LastIndexOf("w"));
            //Console.WriteLine(a.Remove(0,5));
            //string a1 = "   ";
            //Console.WriteLine(string.IsNullOrEmpty(a1));
            //Console.WriteLine(string.IsNullOrWhiteSpace(a1));
            //string[] arr = { "Lorem","Ipsum","Doler","Sit"};
            //Console.WriteLine(string.Join(",", arr));
            //string results = String.Join("-",arr);
            //Console.WriteLine(results);
            //string word = "Hello world";
            //string[] words = word.Split(' ');
            //foreach (var item in words)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] arr = { 2, 5, -3, 14, -10 };
            //Array.Sort(arr);
            //Array.Reverse(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}



            //int[,,] arr = {
            //{
            //      { 3,5}, {4,8 }
            //},
            //{
            //      { 2,7 }, { 7,9}
            //},
            //{
            //      { 3,4 } ,{ 10,12}
            //},
            //};
            //Console.WriteLine(arr[0,1,1]);

            #endregion

            int[] numbers = { 13, 15, 20 };

            int[] result = Resize(ref numbers, 5);
            result[3] = 2;
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }

        }
        static int[] Resize(ref int[] arr, int count)
         {
             int[] newArr = new int[count];
             for (int i = 0; i<arr.Length; i++)
             {
                 newArr[i] = arr[i];
             }

            return newArr;
        }

    }
}
