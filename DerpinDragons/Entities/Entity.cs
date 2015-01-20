using DerpinDragons.Entities.Brains;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons.Entities
{
    public class Entity
    {
        private BrainComponentBase Brain;
        private Texture2D Texture;

        public Vector2 Position;//TODO move to physics component?
        private Vector2 DrawOrigin;//TODO move to animation system
        private Vector2 DrawDimensions;

        public Entity(Texture2D texture, BrainComponentBase brain, Vector2 position, Vector2 drawOrigin)
        {
            this.Brain = brain;
            this.Texture = texture;

            this.Position = position;
            this.DrawOrigin = drawOrigin;

            brain.Sire(this);
        }

        public void Update(GameTime gameTime)
        {
            Brain.Update(gameTime);
        }

        public EntityRenderInfo GetRenderInfo()
        {
            return new EntityRenderInfo(
                Position,
                DrawOrigin,
                Texture);
        }
    }
}
