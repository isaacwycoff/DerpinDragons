using DerpinDragons.Entities;
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

            //TODO this is proto code, get it out of here eventually
            WorldService.AddEntity(EntityFactory.CreatePlayer(new Vector2(100,100)));
        }

        protected override void Update(GameTime gameTime)
        {
            //dont hate me
#if DEBUG
            if(InputService.IsActionHeld(new []{ Microsoft.Xna.Framework.Input.Keys.Escape }))
            {
                this.Exit();
            }
#endif

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
