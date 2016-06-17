using System;
using System.Runtime.Serialization;

namespace ErrorHandling.Exceptions
{
    [Serializable]
    public class ShortcutKeyException : DefaultException
    {

        private const string ErrorMessageKey = "ErrorsKey";

        public new string ErrorMessage { get; }

        public ShortcutKeyException() : this(string.Empty)
        {
        }

        public ShortcutKeyException(string message) : base(message)
        {
            ErrorMessage = message;
        }

        public ShortcutKeyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ShortcutKeyException(SerializationInfo info, StreamingContext context) : base(info, context)
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
