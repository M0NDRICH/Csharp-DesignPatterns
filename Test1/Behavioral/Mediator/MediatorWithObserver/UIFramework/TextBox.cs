using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator.MediatorWithObserver.UIFramework
{
    public class TextBox : UIControl
    {
        private string _text = "";

        public TextBox()
        {
        }

        public string GetText()
        {
            return _text;
        }

        public void SetText(string text)
        {
            _text = text;
            NotifyEventHandlers();
        }
    }
}
