using System;

namespace ErrorHandling.Handlers
{
    interface IExceptionHandler
    {
        void Handle(Exception exception);
    }
}
