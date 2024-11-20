using DSA_PRACTICE.ArrayWork;

namespace DSA_PRACTICE;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        ArrayClass array = new ArrayClass();
        int[] arr = { 1, 2, 0, 4, 3, 0, 5, 0 };
        array.RotateArr(arr, 3);
    }
}

