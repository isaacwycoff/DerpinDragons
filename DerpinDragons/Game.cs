using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons
{
    class DerpinGame : Game
    {
        public DerpinGame()
        {

        }

        protected virtual void Initialize()
        {
            new GraphicsDeviceManager(this);
        }

        protected virtual void LoadContent()
        {
            var spriteBatch = new SpriteBatch(this.GraphicsDevice);
        }

        protected virtual void Update(GameTime gameTime)
        {

        }

        protected virtual void Draw(GameTime gameTime)
        {


        }

        protected virtual void UnloadContent()
        {

        }


    }
}
