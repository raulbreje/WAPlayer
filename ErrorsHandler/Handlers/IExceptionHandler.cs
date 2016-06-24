using System;

namespace ErrorHandling.Handlers
{
    public interface IExceptionHandler
    {
        void Handle(Exception exception);
    }
}
