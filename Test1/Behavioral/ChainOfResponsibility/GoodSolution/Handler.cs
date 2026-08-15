using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.GoodSolution
{
    public abstract class Handler
    {
        private Handler? _nextHandler;

        public Handler SetNextHandler(Handler handler)
        {
            _nextHandler = handler;

            return handler;
        }

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
            {
                return;
            }

            if (_nextHandler != null)
            {
                _nextHandler.Handle(request);
            }
        }

        public abstract bool DoHandle(HttpRequest request);
    }
}
