using System;
using System.Threading.Tasks;

namespace GeneralizedAsyncReturnTypes
{
    class Program
    {
        static void Main(string[] args) => Func();

        public static async ValueTask<int> Func()
        {
            await Task.Delay(100);
            return 5;
        }
    }
}
