using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncStreamsSample
{
    public class ADevice
    {
        public async IAsyncEnumerable<SensorData> GetSensorData()
        {
            var r = new Random();
            while (true)
            {
                await Task.Delay(r.Next(300));
                yield return new SensorData()
                {
                    Value1 = r.Next(100),
                    Value2 = r.Next(100)
                };
            }
        }
    }
}
