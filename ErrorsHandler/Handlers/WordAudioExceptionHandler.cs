using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling.Handlers
{
    class WordAudioExceptionHandler : IExceptionHandler
    {

        private readonly IExceptionHandler successor;

        public WordAudioExceptionHandler(IExceptionHandler successor)
        {
            this.successor = successor;
        }

        public void Handle(Exception exception)
        {
            successor.Handle(exception);
        }
    }
}
