using System;

class Program
{
    static void Main()
    {
        string[] inputArray = new string[] { "One", "two", "three", "6" };
        string[] outputArray = new string[inputArray.Length];
        int outputIndex = 0;

        foreach (string s in inputArray)
        {
            if (s.Length <= 3)
            {
                outputArray[outputIndex++] = s;
            }
        }    

        Console.Read();
    }
}
