using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command.Undoable
{
    public class ItalicCommand : UndoableCommand
    {
        private HtmlDocument _document;
        private string? _prevContent = "";
        private History _history;

        public ItalicCommand(HtmlDocument doc, History history)
        {
            _document = doc;
            _history = history;
        }
        public void Execute()
        {
            _prevContent = _document.Content;
            _document.MakeItalic(); // delegating the work to the doc business object
            _history.Push(this);
        }

        public void Unexecute()
        {
            _document.Content = _prevContent;
        }
    }
}
