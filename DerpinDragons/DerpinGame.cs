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

            Content.RootDirectory = "Content";

        }

        protected override void Initialize()
        {
            this.Graphics.Initialize(this.GraphicsDevice);
            base.Initialize();          // this MUST happen at the end, 'cause XNA blows.
        }

        protected override void LoadContent()
        {
            this.Graphics.LoadContent(this.Content);
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
