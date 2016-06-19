using System.ComponentModel.Composition;

namespace MefInstancePicker
{
    [Export(typeof(IHelloWorldMessage))]
    [PrimaryExport]
    public class LeetHelloWorld : IHelloWorldMessage
    {
        public string SayHello()
        {
            return "1337! H3770 W0R7D !!!111!1!1!!!111";
        }
    }
}
