using DerpinDragons.Services;
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
            InputService.Initialize();
            this.Graphics.Initialize(this.GraphicsDevice);
            WorldService.Initialize();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            ContentService.LoadAllTextures(Content);
            this.Graphics.LoadContent(this.Content);
        }

        protected override void Update(GameTime gameTime)
        {
            InputService.Update(gameTime);
            WorldService.Update(gameTime);
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
