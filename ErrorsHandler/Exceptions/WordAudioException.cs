using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling.Exceptions
{
    [Serializable]
    public class WordAudioException : DefaultException
    {

        private const string ErrorMessageKey = "ErrorsKey";

        public new string ErrorMessage { get; }

        public WordAudioException() : this(string.Empty)
        {
        }

        public WordAudioException(string message) : base(message)
        {
            ErrorMessage = message;
        }

        public WordAudioException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WordAudioException(SerializationInfo info, StreamingContext context) : base(info, context)
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
