using MyErp.PrintService.Interfaces;
using Newtonsoft.Json;

namespace MyErp.PrintService
{
    public class PrintService : IPrintService
    {
        public void Print<T>(T input)
        {
            string json = JsonConvert.SerializeObject(input);
            Console.WriteLine(json);
        }
    }
}
