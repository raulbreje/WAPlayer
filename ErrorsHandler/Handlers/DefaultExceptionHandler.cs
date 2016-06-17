using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorHandling.Exceptions;

namespace ErrorHandling.Handlers
{
    internal class DefaultExceptionHandler : IExceptionHandler
    {
        public void Handle(Exception exception)
        {
            throw new DefaultException(exception);
        }
    }
}
