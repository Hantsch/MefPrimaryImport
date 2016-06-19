using System;
using System.ComponentModel.Composition;

namespace MefInstancePicker
{
    [Export]
    public class HelloWorldShouter
    {
        private IHelloWorldMessage Message;

        [ImportingConstructor]
        public HelloWorldShouter(IHelloWorldMessage message)
        {
            this.Message = message;
        }

        public void ShoutHello()
        {
            Console.WriteLine(this.Message.SayHello());
        }
    }
}
