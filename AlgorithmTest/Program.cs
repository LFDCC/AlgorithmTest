using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //冒泡
                int count = 0;
                int[] arr = new int[] { -1, 9, 3, 5, 4, 1, -1, -4 };
                Console.WriteLine("原始序列：" + string.Join(",", arr));
                int len = arr.Length;
                int temp = 0;
                Console.WriteLine("===================查找开始===================");
                for (int i = 0; i < len; i++)
                {
                    //遍历当前位置后面的所有值 遇到小于当前值的 就交换位置  
                    for (int j = (i + 1); j < len; j++)
                    {
                        count++;

                        Console.WriteLine("===========================================");

                        Console.WriteLine($"对比值：arr[{i}]={arr[i]},arr[{j}]={arr[j]}");

                        if (arr[j] < arr[i])
                        {
                            Console.WriteLine("需要交换");
                            temp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = temp;
                        }
                        else
                        {
                            Console.WriteLine("不需要交换");
                        }

                        Console.WriteLine($"遍历结果：{string.Join(",", arr)}");

                    }
                }
                Console.WriteLine("===================查找结束===================");
                Console.WriteLine("查找次数：" + count);
                Console.WriteLine("排序后序列：" + string.Join(",", arr));
                Console.ReadKey();

            }
        }
    }
}
