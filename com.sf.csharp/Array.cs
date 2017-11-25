using System;

namespace com.sf.csharp
{
    public class Array
    {
        public class com_sf_Array
        {
            /*
             * 判断泛型的具体类型并返回，数组中元素正确的包裹者
             */
            private static string getType<T>()
            {
                string  p="";
                if (typeof(T) == typeof(string))
                {
                    p = "\"";
                }
                else if(typeof(T) == typeof(char))
                {
                    p = "'";
                }
                return p;
            }
            /**
             * 打印一维数组中的所有元素
             */
            public static void printArray<T>(T[] array)
            {
                //保存数组中元素的包裹者
                string p = getType<T>();
                Console.Write("{");
                for(int i=0;i<array.Length;i++)
                {
                    Console.Write("{0}{1}{2}",p,array[i],p);
                    Console.Write(i==(array.Length-1)?(""):(","));
                }
                Console.Write("}\n");

            }
            /**
             * 打印二维数组中的所有元素
             */
            public static void printArray<T>(T[,] array)
            {
                String p = getType<T>();
                Console.Write("{\n    ");
                for (int i = 0; i<array.Rank; i++)
                {
                    Console.Write("{");
                    for(int j=0;j<array.Length/array.Rank;j++)
                    {
                        Console.Write("{0}{1}{2}",p,array[i,j],p);
                        Console.Write(j==((array.Length/array.Rank)-1)?(""):(","));
                    
                    }
                    Console.Write(i==(array.Rank-1)?"}\n":"},\n    ");

                }
                Console.Write("}\n");
            }
        }
    }
}