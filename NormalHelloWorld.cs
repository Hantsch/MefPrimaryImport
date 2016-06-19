using System.ComponentModel.Composition;

namespace MefInstancePicker
{
    [Export(typeof(IHelloWorldMessage))]
    public class NormalHelloWorld : IHelloWorldMessage
    {
        public string SayHello()
        {
            return "Hello World";
        }
    }
}
