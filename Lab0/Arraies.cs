public class Array2
{
    public int findLast(int[] arr, int x)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == x)
                return i;
        }
        return -1;
    }

    public static void Launch()
    {
        Array2 proj = new Array2();
        Console.WriteLine("Введите массив. Числа через пробел");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine("Введите число");
        Console.WriteLine(proj.findLast(arr, int.Parse(Console.ReadLine()))); // 5
    }
}

public class Array4
{
    public int[] add(int[] arr, int x, int pos)
    {
        int[] newArr = new int[arr.Length + 1];

        for (int i = 0; i < pos; i++)
            newArr[i] = arr[i];

        newArr[pos] = x;

        for (int i = pos; i < arr.Length; i++)
            newArr[i + 1] = arr[i];

        return newArr;
    }

    public static void Launch()
    {
        Array4 proj = new Array4();
        Console.WriteLine("Введите массив. Числа через пробел");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine("Введите число и позицию");
        int[] result = proj.add(arr, int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        Console.WriteLine(string.Join(", ", result)); // 1, 2, 3, 9, 4, 5
    }
}

public class Array6
{
    public void reverse(int[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }
    }

    public static void Launch()
    {
        Array6 proj = new Array6();
        Console.WriteLine("Введите массив. Числа через пробел");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        proj.reverse(arr);
        Console.WriteLine(string.Join(", ", arr));
    }
}

public class Array8
{
    public int[] concat(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length + arr2.Length];

        for (int i = 0; i < arr1.Length; i++)
            result[i] = arr1[i];

        for (int i = 0; i < arr2.Length; i++)
            result[arr1.Length + i] = arr2[i];

        return result;
    }

    public static void Launch()
    {
        Array8 proj = new Array8();
        Console.WriteLine("Введите 2 массива. Числа через пробел");
        int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] result = proj.concat(arr1, arr2);
        Console.WriteLine(string.Join(", ", result)); // 1, 2, 3, 7, 8, 9
    }
}

public class Array10
{
    public int[] deleteNegative(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
                count++;
        }
        
        int[] result = new int[count];
        int index = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                result[index] = arr[i];
                index++;
            }
        }
        
        return result;
    }

    public static void Launch()
    {
        Array10 proj = new Array10();
        Console.WriteLine("Введите массив. Числа через пробел");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] result = proj.deleteNegative(arr);
        Console.WriteLine(string.Join(", ", result)); // 1, 2, 4, 2
    }
}    