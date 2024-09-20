using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Command
{
    public class ToggleTurbo : Command
    {
        private CBikeController _controller;

        public ToggleTurbo(CBikeController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.ToggleTurbo();
        }
    }
}

