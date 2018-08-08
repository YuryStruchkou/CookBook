using System;

namespace CoreProject.Helpers
{
    public class SerializationException : Exception
    {
        public SerializationException() : base()
        {
            
        }

        public SerializationException(string message) : base(message)
        {
            
        }

        public SerializationException(string message, Exception parentException) : base(message, parentException)
        {
            
        }
    }
}
