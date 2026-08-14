using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State.GoodSolution
{
    internal class DraftState : State
    {
        private Document _document;

        public DraftState(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            _document.State = new ModerationState(_document);
        }
    }
}
