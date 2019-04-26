using System;
using System.Threading.Tasks;

namespace AsyncStreamsSample
{
    class Program
    {
        static async Task Main()
        {
            var aDevice = new ADevice();
            await foreach (var x in aDevice.GetSensorData())
            {
                Console.WriteLine($"{x.Value1} {x.Value2}");
            }
        }
    }
}
