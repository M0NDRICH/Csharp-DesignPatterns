using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Button : UIControl
    {
        private bool _isEnabled;
        public Button(DialogBox owner) : base(owner)
        {
        }

        public bool isEnabled()
        {
            return _isEnabled;
        }

        public void SetEnabled(bool isEnabled)
        {
            _isEnabled = isEnabled;
            _owner.Changed(this);
        }
    }
}
