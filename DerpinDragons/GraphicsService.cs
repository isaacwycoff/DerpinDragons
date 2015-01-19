using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons
{
    public class GraphicsService
    {
        private const int ScreenWidth = 1024;
        private const int ScreenHeight = 768;
        private bool IsFullScreen = false;

        private SpriteBatch SpriteBatch { get; set; }
        private GraphicsDevice GraphicsDevice { get; set; }
        private GraphicsDeviceManager GraphicsDeviceManager { get; set; }

        private SpriteFont Font { get; set; }

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

            this.Font = contentManager.Load<SpriteFont>("FixedFont");
        }

        public void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.HotPink);

            SpriteBatch.Begin(sortMode: SpriteSortMode.Deferred,
                blendState: BlendState.AlphaBlend,
                samplerState: SamplerState.PointWrap,
                depthStencilState: DepthStencilState.Default,
                rasterizerState: RasterizerState.CullNone);

            SpriteBatch.DrawString(this.Font, "DERPIN' DRAGONS", Vector2.Zero, Color.AntiqueWhite);

            SpriteBatch.End();
        }

        public void Update(GameTime gameTime)
        {

        }
    }
}
