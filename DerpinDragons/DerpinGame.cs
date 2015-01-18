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
        private GraphicsService Graphics { get; set; }

        public DerpinGame() : base()
        {
            this.Graphics = new GraphicsService(this);

        }

        protected override void Initialize()
        {
            base.Initialize();
            this.Graphics.Initialize(this.GraphicsDevice);
        }

        protected override void LoadContent()
        {
            this.Graphics.LoadContent();


            // var spriteBatch = new SpriteBatch(this.GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            this.Graphics.Draw(gameTime);

            base.Draw(gameTime);
        }

        protected override void UnloadContent()
        {

        }


    }
}
