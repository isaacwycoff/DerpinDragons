using DerpinDragons.Entities.Animations;
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

        private AnimationSystem AnimationComponent;

        public Vector2 Position;//TODO move to physics component?
        public float Rotation;
        private Texture2D Texture;

        public Entity(Vector2 position, AnimationFrame[][] animationSet, Texture2D texture)
        {
            this.Texture = texture;
            this.Position = position;
            this.AnimationComponent = new AnimationSystem(animationSet);
        }

        public void Update(GameTime gameTime)
        {
            Brain.Update(gameTime);
            AnimationComponent.Update(gameTime);
        }

        public EntityRenderInfo GetRenderInfo()
        {
            var currentFrame = AnimationComponent.GetCurrentFrame().GetRenderableFrameForDirection(0f);
            return new EntityRenderInfo(
                Position,
                currentFrame.Origin,
                Texture,
                currentFrame.SourceRectangle,
                currentFrame.Scale);
        }

        public void Initialize(BrainComponentBase brain)
        {
            Brain = brain;
        }
    }
}
