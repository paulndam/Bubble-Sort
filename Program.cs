using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Rico!");

            int [] integerValues = {4,2,-1,8,20,14,-16,35, 19, 30, 76, -45, 60};
            bubbleSort(integerValues);
            Console.WriteLine(string.Join(" | ", integerValues));
        }




        public static void bubbleSort<T>(T[] array)where T: IComparable{

            for(int i = 0; i < array.Length; i++){
                for(int j = 0; j < array.Length - 1; j++){

                    if(array[j].CompareTo(array[j+1])< 0){

                        Swap(array, j, j+1);

                    }
                }

                
            }
           
        }

        private static void Swap<T>(T[] array, int first, int second)where T: IComparable{

            T temp = array[first];
            array[first]= array[second];
            array[second]= temp;
        }




        


















    }
}
