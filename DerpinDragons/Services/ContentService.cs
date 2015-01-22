using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons.Services
{
    public static class ContentService
    {
        public static Texture2D DevTexture;
        public static SpriteFont DevFont;

        public static Texture2D DerpyDwarf;

        public static SpriteFont FixedFont;

        public static void LoadAllTextures(ContentManager content)
        {
            DevTexture = content.Load<Texture2D>("DevTexture");//we always assume this will load, I'm committing it to the repo
            DevFont = content.Load<SpriteFont>("DevFont"); //same with this one

            DerpyDwarf = SafeLoadTexture(content, "DerpyDwarf");
            FixedFont = SafeLoadFont(content, "FixedFont");
        }

        private static Texture2D SafeLoadTexture(ContentManager content, string textureName)
        {
            try
            {
                return content.Load<Texture2D>(textureName);
            }
            catch
            {
                return DevTexture;
            }
        }

        private static SpriteFont SafeLoadFont(ContentManager content, string fontName)
        {
            try
            {
                return content.Load<SpriteFont>(fontName);
            }
            catch
            {
                return DevFont;
            }
        }
    }
}
