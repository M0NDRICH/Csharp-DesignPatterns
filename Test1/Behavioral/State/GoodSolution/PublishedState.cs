using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State.GoodSolution
{
    internal class PublishedState : State
    {
        private Document _document;

        public PublishedState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            // do nothing if already in published state
        }
    }
}
