namespace FinalControl
{
    internal class Program
    {
        static string[] CreateArray(int length)
        {
            string[] array = new string[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i} элемент массива - ");
                array[i] = Console.ReadLine()!;
            }

            return array;
        }

        static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        static string[] CreateNewArrayMax3Length(string[] array)
        {
            
            int index = 0;
            int lengthNewArray = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    
                    lengthNewArray++;
                }
                    
            }
            string[] newArray = new string[lengthNewArray];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    newArray[index] = array[i];
                    index++;
                }
                    
            }
            Console.WriteLine(newArray.Length);
            return newArray;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов в массиве - ");
            int.TryParse(Console.ReadLine(), out int n);
            string[] array = CreateArray(n);
            PrintArray(array);
            string[] newArray = CreateNewArrayMax3Length(array);
            PrintArray(newArray);



        }
    }
}