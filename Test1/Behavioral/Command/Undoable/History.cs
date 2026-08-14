using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command.Undoable
{
    public class History
    {
        private List<UndoableCommand> _commands = new List<UndoableCommand>();

        public void Push(UndoableCommand command)
        {
            _commands.Add(command);
        }

        public UndoableCommand Pop()
        {
            var last = _commands.Last();
            _commands.Remove(last);

            return last;
        }

        public int Size()
        {
            return _commands.Count;
        }
    }
}
