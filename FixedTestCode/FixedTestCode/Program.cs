namespace FixedTestCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        //: שאלה מספר 1
        public static bool IsNice(int[] arr)
        {
            int currSum = 0, cnt = 0;
            if (arr[0] != 0)
            {
                return false;
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == -999)
                {
                    if (i == arr.Length - 1)
                    {
                        return false;
                    }
                    if (arr[i + 1] != currSum)
                    {
                        return false;
                    }
                    currSum = 0;
                    cnt = 0;
                }
                else if (i < arr.Length - 1)
                {
                    currSum += arr[i];
                    cnt++;
                }
                else if (arr[i] != currSum || cnt != 0)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
