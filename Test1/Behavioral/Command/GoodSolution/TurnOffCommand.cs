using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command.GoodSolution
{
    public class TurnOffCommand : ICommand
    {
        private Light _light;

        public TurnOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }
}
