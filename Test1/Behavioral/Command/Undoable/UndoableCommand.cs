using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command.Undoable
{
    public interface UndoableCommand : Command
    {
        void Unexecute();
    }
}
