using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // get chars count from string
        GetCharsCount();


        // Salary Calculation
        double salary = 200000;
        float tax = 0.2f; // Income tax 20%
        float social = 0.05f; // social fee 10%
        float stamp = 0.015f; // stamp fee 1.5%
        SalaryCalc(ref salary, tax, social, stamp);
        Console.WriteLine(salary);


        // Recursion
        int n = 0;
        int[] arr = { };
        recursionExample(n, ref arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        ////////////////////////////////////
        Console.ReadKey();
    }

    static void GetCharsCount()
    {
        StringBuilder myString = new StringBuilder("aksghdvfkhuasdbfukasbdjkfbaskjhdfbasdbfhkasbdfkjh,sdfbhukzj");
        int[,] strItems = new int[myString.Length, 2];
        int max = 0;
        for (int i = 0; i < myString.Length; i++)
        {
            strItems[i, 0] = (int)myString[i];
            strItems[i, 1] = 1;

            for (int j = i + 1; j < myString.Length; j++)
            {
                if (myString[j] == myString[i])
                {
                    strItems[i, 1] += 1;
                    myString = myString.Remove(j, 1);

                }
            }
            if (strItems[i, 1] > max) max = strItems[i, 1];

            Console.WriteLine((char)strItems[i, 0] + " = " + strItems[i, 1]);
        }

        Console.WriteLine("MAX" + " ------------- " + max);

    }


    static void SalaryCalc(ref double salary, float tax, float social, float stamp)
    {
        double percent = tax + social + stamp;
        salary = Math.Round(salary * percent);
    }

    static void recursionExample(int n, ref int[] arr)
    {
        // Fibonaci with recursion
        if (arr.Length < 2)
        {
            arr = arr.Append(n).ToArray();
        }
        else if (arr.Length == 2)
        {
            arr = arr.Append(arr[0] + arr[1]).ToArray();
        }
        else if (arr.Length >= 3)
        {

            arr = arr.Append(arr[n - 1] + arr[n - 2]).ToArray();
        }

        if (n < 15) recursionExample(n + 1, ref arr);
    }
}
}