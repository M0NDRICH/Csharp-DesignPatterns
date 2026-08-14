using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator.MediatorWithObserver.UIFramework
{
    public class ListBox : UIControl
    {
        private string _selection = "";
        public ListBox() 
        {
        }

        public string GetSelection()
        {
            return _selection;
        }

        public void SetSelection(string selection)
        {
            _selection = selection;

            NotifyEventHandlers();
        }
    }
}
