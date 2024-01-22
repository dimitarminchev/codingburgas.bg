using System.Text;

namespace BufferedConsole
{
    public class BufferedConsole : IDisposable
    {
        private const int maxBufferLength = 50;

        private byte[] textBuffer = new byte[maxBufferLength];

        private int textPosition = 0;

        public void Write(string text)
        {
            var tempBuffer = Encoding.UTF8.GetBytes(text);

            for (int i = 0; i < tempBuffer.Length && textPosition < maxBufferLength; i++) 
            {
                textBuffer[textPosition] = tempBuffer[i];
                textPosition++;
            }

            if (textBuffer.Length >= maxBufferLength)
            {
                Dispose();
            }
        }

        public void Dispose()
        {
            Console.WriteLine(Encoding.UTF8.GetString(textBuffer));
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            BufferedConsole console = new BufferedConsole();

            console.Write("Hello");
            console.Write("World");
            console.Write("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
        }
    }
}
