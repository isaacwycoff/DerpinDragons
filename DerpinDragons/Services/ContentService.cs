using DerpinDragons.Entities.Animations;
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
    public static class ContentService
    {
        //dev
        public static Texture2D DevTexture;
        public static SpriteFont DevFont;

        //textures
        public static Texture2D DerpyDwarf;

        //animations
        public static AnimationFrame[][] DerpyDwarfAnimationSet;

        //fonts
        public static SpriteFont FixedFont;


        public static void LoadAllTextures(ContentManager content)
        {
            DevTexture = content.Load<Texture2D>("DevTexture");//we always assume this will load, I'm committing it to the repo
            DevFont = content.Load<SpriteFont>("DevFont"); //same with this one

            DerpyDwarf = SafeLoadTexture(content, "Hero_1a");
            FixedFont = SafeLoadFont(content, "FixedFont");

            DerpyDwarfAnimationSet = SafeLoadAnimationSet("DerpyDwarf");
        }

        private static AnimationFrame[][] SafeLoadAnimationSet(string fileName)
        {
            //TODO this should be loaded from a file, but for now it's hardcoded
            return new AnimationFrame[][]
            {
                new AnimationFrame[]
                {
                        new AnimationFrame(
                            1000, 
                            new []{ new Vector2(200,200) },
                            new []{ new Vector2(1,1) },
                            new Rectangle[]{ new Rectangle(8,8,8,8) }),
                        new AnimationFrame(
                            1000, 
                            new []{ new Vector2(20,20) },
                            new []{ new Vector2(1,1) },
                            new Rectangle[]{ new Rectangle(0,0,8,8) })
                }
            };
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
