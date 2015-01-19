using DerpinDragons.Input;
using DerpinDragons.Services;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons.Entities.Brains
{
    class PlayerBrain : BrainComponentBase
    {
        public PlayerBrain()
        { }

        public override void Update(GameTime gameTime)
        {
            Vector2 movementDirection = Vector2.Zero;

            if (InputService.IsActionHeld(InputActionDefinitions.Player1MoveDown))
            {
                movementDirection += new Vector2(0, 1);
            }

            if (InputService.IsActionHeld(InputActionDefinitions.Player1MoveUp))
            {
                movementDirection += new Vector2(0, -1);
            }

            if (InputService.IsActionHeld(InputActionDefinitions.Player1MoveLeft))
            {
                movementDirection += new Vector2(-1, 0);
            }

            if (InputService.IsActionHeld(InputActionDefinitions.Player1MoveRight))
            {
                movementDirection += new Vector2(1, 0);
            }

            //TODO physics ideal
            //Context.Physics.SetMovementDirection(movementDirection);
            Context.Position += movementDirection;
        }
    }
}
