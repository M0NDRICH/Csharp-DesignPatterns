using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command.GoodSolution
{
    public class TurnOnCommand : ICommand
    {
        private Light _light;

        public TurnOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}
