namespace FixedTestCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {0, 3, 7, 5, -999, 15, 6, 1, 2, -999, 24, 3, 3, -999, 30, 2, 8, -999, 40};
            Console.WriteLine(IsNice(arr));
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
