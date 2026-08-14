using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class DialogBox
    {
        public abstract void Changed(UIControl uiControl);
    }
}
