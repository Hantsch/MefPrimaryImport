using System;
using System.ComponentModel.Composition.Hosting;

namespace MefInstancePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new AssemblyCatalog(typeof(Program).Assembly);

            var container = new CompositionContainer(catalog, new PrimaryExportPreferedExportProvider(catalog));
            
            var shouter = container.GetExport<HelloWorldShouter>();
            shouter.Value.ShoutHello();

            Console.ReadLine();
        }
    }
}
