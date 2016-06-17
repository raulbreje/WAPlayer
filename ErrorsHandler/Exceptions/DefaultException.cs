using System;
using System.Runtime.Serialization;

namespace ErrorHandling.Exceptions
{
    public class DefaultException : Exception
    {

        private const string ErrorMessageKey = "ErrorMessage";

        public string ErrorMessage { get; }

        public DefaultException() : this(string.Empty)
        {
        }

        public DefaultException(string message) : base(message)
        {
            ErrorMessage = message;
        }

        public DefaultException(Exception exception)
            : base(exception.Message, exception)
        {
            ErrorMessage = exception.Message;
        }


        public DefaultException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DefaultException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            ErrorMessage = info.GetString(ErrorMessageKey);
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue(ErrorMessageKey, ErrorMessage, typeof(string));
        }
    }
}
