namespace FixedTestCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }

        //: שאלה מספר 1
        public static bool IsNice(int[] arr)
        {
            int currSum = 0;
            if (arr[0] != 0 || arr[arr.Length-2] != -999)
            {
                return false;
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == -999)
                {
                    if (arr[i + 1] != currSum)
                    {
                        return false;
                    }
                    currSum = 0;
                }
                else if (i < arr.Length - 1)
                {
                    currSum += arr[i];
                }
            }
            return true;
        }


    }
}
