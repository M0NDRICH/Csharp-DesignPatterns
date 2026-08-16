using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Interpreter
{
    public interface IExpression
    {
        int Interpret(Context context);
    }
}
