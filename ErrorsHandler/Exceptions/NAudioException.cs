using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling.Exceptions
{
    [Serializable]
    public class NAudioException : DefaultException
    {

        private const string ErrorMessageKey = "ErrorsKey";

        public new string ErrorMessage { get; }

        public NAudioException() : this(string.Empty)
        {
        }

        public NAudioException(string message) : base(message)
        {
            ErrorMessage = message;
        }

        public NAudioException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NAudioException(SerializationInfo info, StreamingContext context) : base(info, context)
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
