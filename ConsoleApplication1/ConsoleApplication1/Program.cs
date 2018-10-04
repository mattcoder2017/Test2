using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> VersionTags = new Dictionary<string, string>();
            VersionTags.Add("Master", "1");
            VersionTags.Add("Master", "2");
            foreach (var obj in VersionTags)
            {
                Console.WriteLine("Key : {0} Value : {1}", new String[]{obj.Key, obj.Value });
            }
            Console.Read();
        }

    }
}
