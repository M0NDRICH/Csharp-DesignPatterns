using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    public class ListBox : UIControl
    {
        private string _selection = "";
        public ListBox(DialogBox owner) : base(owner)
        {
        }

        public string GetSelection()
        {
            return _selection;
        }

        public void SetSelection(string selection)
        {
            _selection = selection;

            _owner.Changed(this);
        }
    }
}
