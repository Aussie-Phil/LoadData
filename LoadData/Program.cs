using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadData
{
    class Program
    {
        static int Main(string[] args)
        {
            int result = 0;
            LoadEngine engine = new LoadEngine();

            //Check we have a parameter
            if (args.Length != 1)
            {
                Console.Error.WriteLine("Usage:");
                Console.Error.WriteLine("DataLoader Path");
                Console.Error.WriteLine("");
                Console.Error.WriteLine("Path:  Is a valid path on this computer.");
                Console.Error.WriteLine("");
                Console.Error.WriteLine("Output:");
                Console.Error.WriteLine("Returns an int to %ERRORLEVEL%.");
                Console.Error.WriteLine("output <=  0:  Error occurred - The codes are not defined here. See source code.");
                Console.Error.WriteLine("output =  1:  Data successfully loaded.");
                Console.Error.WriteLine("");
                return Constants.LoadConstants.ErrNoPath;
            }

            result = engine.Load(args[0]);

            return result;

        }
    }
}
