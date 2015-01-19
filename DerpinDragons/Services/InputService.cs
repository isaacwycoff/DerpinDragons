using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons.Services
{
    public class InputService
    {
        private static InputService Instance;

        public KeyboardState PreviousKeystate;
        public KeyboardState CurrentKeystate;

        private InputService()
        {
            PreviousKeystate = CurrentKeystate = Keyboard.GetState();
        }

        public static void Initialize()
        {
            Instance = new InputService();
        }

        public static void Update(GameTime gameTime)
        {
            Instance.PreviousKeystate = Instance.CurrentKeystate;
            Instance.CurrentKeystate = Keyboard.GetState();
        }

        /// <summary>
        /// Do not use a key, use an InputActionDefinition
        /// </summary>
        public static bool IsActionHeld(Keys[] keys) //this can be set to a mapping later
        {
            foreach (var key in keys)
            {
                if (Instance.CurrentKeystate.IsKeyDown(key))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Do not use a key, use an InputActionDefinition
        /// </summary>
        public static bool WasActionPressed(Keys[] keys) 
        {
            foreach (var key in keys)
            {
                if (Instance.PreviousKeystate.IsKeyUp(key)
                    && Instance.CurrentKeystate.IsKeyDown(key))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
