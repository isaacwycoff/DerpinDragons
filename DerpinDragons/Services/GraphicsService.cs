using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons.Services
{
    public class GraphicsService
    {
        private const int ScreenWidth = 1024;
        private const int ScreenHeight = 768;
        private bool IsFullScreen = false;

        private SpriteBatch SpriteBatch { get; set; }
        private GraphicsDevice GraphicsDevice { get; set; }
        private GraphicsDeviceManager GraphicsDeviceManager { get; set; }

        public GraphicsService(Game game)
        {
            // this.GraphicsDevice = graphicsDevice;
            this.GraphicsDeviceManager = new GraphicsDeviceManager(game);

            this.GraphicsDeviceManager.PreferredBackBufferWidth = ScreenWidth;
            this.GraphicsDeviceManager.PreferredBackBufferHeight = ScreenHeight;
            this.GraphicsDeviceManager.IsFullScreen = IsFullScreen;
        }

        public void Initialize(GraphicsDevice graphicsDevice)
        {
            this.GraphicsDevice = graphicsDevice;
        }

        public void LoadContent(ContentManager contentManager)
        {
            this.SpriteBatch = new SpriteBatch(this.GraphicsDevice);
        }

        public void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.HotPink);

            SpriteBatch.Begin(sortMode: SpriteSortMode.Deferred,
                blendState: BlendState.AlphaBlend,
                samplerState: SamplerState.PointWrap,
                depthStencilState: DepthStencilState.Default,
                rasterizerState: RasterizerState.CullNone);

            //TODO viewArea would come from camera that doesn't exist yet
            var viewArea = new Rectangle(0, 0, ScreenWidth, ScreenHeight);
            var drawableEntities = WorldService.GetEntitiesInViewableArea(viewArea);

            foreach (var entity in drawableEntities)
            {
                var drawInfo = entity.GetRenderInfo();
                SpriteBatch.Draw(drawInfo.Texture, drawInfo.DrawPosition, null, Color.White, 0f, drawInfo.Origin, 1f, SpriteEffects.None, .5f);
            }

            SpriteBatch.DrawString(ContentService.FixedFont, "DERPIN' DRAGONS", Vector2.Zero, Color.AntiqueWhite);

            SpriteBatch.End();
        }

        public void Update(GameTime gameTime)
        {

        }
    }
}
