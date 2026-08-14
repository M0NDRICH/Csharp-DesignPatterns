using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator.MediatorWithObserver.UIFramework
{
    public class UIControl
    {
        private List<EventHandler> _eventHandlers = new List<EventHandler>();
    }
}
