using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State.GoodSolution
{
    public class ModerationState : State
    {
        private Document _document;

        public ModerationState(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            if (_document.CurrentUserRole == UserRoles.Admin)
            {
                _document.State = new PublishedState(_document);
            }
        }
    }
}
