using HelloWorld.Message;

namespace HelloWorld.Core
{
    public class Greet
    {
        public string SayHello()
        {
            var response = new SayHelloResponse();
            return "hello world";
        }
    }
}
