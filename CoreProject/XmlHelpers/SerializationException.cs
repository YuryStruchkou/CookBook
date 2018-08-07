using System;

namespace CoreProject.XmlHelpers
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
