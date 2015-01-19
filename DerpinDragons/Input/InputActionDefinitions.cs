using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons.Input
{
    //just throwing this here so we can use the proper syntax and refactor later
    public static class InputActionDefinitions
    {
        public static Keys[] Player1MoveDown = { Keys.S, Keys.Down };
        public static Keys[] Player1MoveUp = { Keys.W, Keys.Up };
        public static Keys[] Player1MoveLeft = { Keys.A, Keys.Left };
        public static Keys[] Player1MoveRight = { Keys.D, Keys.Right };
    }
}
