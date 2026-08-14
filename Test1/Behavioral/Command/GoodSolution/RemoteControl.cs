using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command.GoodSolution
{
    // Sender
    public class RemoteControl
    {
        private ICommand _command;

        public RemoteControl(ICommand command)
        {
            _command = command;
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }
}
