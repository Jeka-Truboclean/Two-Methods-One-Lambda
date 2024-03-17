namespace _19._03
{
    class Program
    {
        delegate bool IsEquals<T>(T n);
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] MethodFilter = Filter(arr, FilterMethod);
            int[] AnonymMethodFilter = Filter(arr, delegate (int n)
            {
                return n % 2 == 0;
            });
            int[] Lambda = Filter(arr, n => n % 2 == 0);
        }
        private static bool FilterMethod(int n)
        {
            return n % 2 == 0;
        }
        static T[] Filter<T>(T[] arr, IsEquals<T> isEquals)
        {
            T[] arr2 = new T[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (isEquals(arr[i]))
                {
                    Array.Resize(ref arr2, arr2.Length + 1);
                    arr2[arr2.Length - 1] = arr[i];
                }
            }
            return arr2;
        }
    }
}
