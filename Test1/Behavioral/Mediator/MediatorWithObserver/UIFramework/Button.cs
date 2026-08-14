using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator.MediatorWithObserver.UIFramework
{
    public class Button : UIControl
    {
        private bool _isEnabled;
        public Button()
        {
        }

        public bool isEnabled()
        {
            return _isEnabled;
        }

        public void SetEnabled(bool isEnabled)
        {
            _isEnabled = isEnabled;
            NotifyEventHandlers();
        }
    }
}
