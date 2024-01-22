using System.Text;

namespace BufferedConsole
{
    public class BufferedConsole : IDisposable
    {
        // A 50-byte buffer to store the strings
        private byte[] buffer = new byte[50];

        // A counter to keep track of the buffer size
        private int count = 0;

        // A stream to write to the console
        private Stream stream = Console.OpenStandardOutput();

        // A flag to indicate whether the object is disposed
        private bool disposed = false;

        // A finalizer to clean up the resources
        ~BufferedConsole()
        {
            Dispose(false);
        }

        // A method to write a string to the buffer
        public void Write(string s)
        {
            // Check if the object is disposed
            if (disposed)
            {
                throw new ObjectDisposedException("BufferedConsole");
            }

            // Convert the string to bytes
            byte[] bytes = Encoding.UTF8.GetBytes(s);

            // Check if the buffer can fit the bytes
            if (count + bytes.Length > buffer.Length)
            {
                // Flush the buffer to the stream
                Flush();

                // Check if the bytes can fit the buffer
                if (bytes.Length > buffer.Length)
                {
                    // Write the bytes directly to the stream
                    stream.Write(bytes, 0, bytes.Length);
                }
                else
                {
                    // Copy the bytes to the buffer
                    Array.Copy(bytes, 0, buffer, 0, bytes.Length);
                    count = bytes.Length;
                }
            }
            else
            {
                // Copy the bytes to the buffer
                Array.Copy(bytes, 0, buffer, count, bytes.Length);
                count += bytes.Length;
            }
        }

        // A method to flush the buffer to the stream
        public void Flush()
        {
            // Check if the object is disposed
            if (disposed)
            {
                throw new ObjectDisposedException("BufferedConsole");
            }

            // Check if the buffer is not empty
            if (count > 0)
            {
                // Write the buffer to the stream
                stream.Write(buffer, 0, count);

                // Reset the counter
                count = 0;
            }
        }

        // A method to dispose the object and release the resources
        public void Dispose()
        {
            Dispose(true);

            // Suppress the finalizer
            GC.SuppressFinalize(this);
        }

        // A method to dispose the object and release the resources
        protected virtual void Dispose(bool disposing)
        {
            // Check if the object is already disposed
            if (!disposed)
            {
                // Check if the disposing parameter is true
                if (disposing)
                {
                    // Flush the buffer to the stream
                    Flush();

                    // Dispose the stream
                    stream.Dispose();
                }

                // Set the disposed flag to true
                disposed = true;
            }
        }
    }
}
