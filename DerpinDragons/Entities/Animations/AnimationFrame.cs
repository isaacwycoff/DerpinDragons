using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DerpinDragons.Entities.Animations
{
    public class AnimationFrame
    {
        private float RadianThreshold;

        public int FrameTimeMilli { get; private set; }
        private Vector2[] DrawOrigin;
        private Rectangle?[] TextureSourceRectangle;
        private Texture2D[] Textures;
        private Vector2[] Scale;

        public AnimationFrame(int frameTime, Vector2[] drawSize, Vector2[] drawOrigin, Rectangle?[] textureSourceRectangle, Texture2D[] textures)
        {
            FrameTimeMilli = frameTime;
            DrawOrigin = drawOrigin;
            TextureSourceRectangle = textureSourceRectangle;
            Textures = textures;

            Scale = new Vector2[Textures.Count()];
            for (int i = 0; i < Textures.Count(); ++i)
            {
                Scale[i] = new Vector2(drawSize[i].X / (float)Textures[i].Bounds.Width, drawSize[i].Y / (float)textures[i].Bounds.Width);
            }

            RadianThreshold = (float)(Math.PI / Textures.Count());
        }

        public RenderableFrameForDirection GetRenderableFrameForDirection(float angle)
        {
            //this is for clockwise assets, hope this math is right O_o
            var rotationIndex = (int)Math.Floor(angle/RadianThreshold);

            return new RenderableFrameForDirection()
            {
                Origin = DrawOrigin[rotationIndex],
                Scale = Scale[rotationIndex],
                SourceRectangle = TextureSourceRectangle[rotationIndex],
                Texture = Textures[rotationIndex],
            };
        }
    }

    public class RenderableFrameForDirection
    {
        public Vector2 Scale;
        public Vector2 Origin;
        public Rectangle? SourceRectangle;
        public Texture2D Texture;
    }
}
