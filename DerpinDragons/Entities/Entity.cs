using DerpinDragons.Entities.Animations;
using DerpinDragons.Entities.Brains;
using DerpinDragons.Entities.States;
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

        public Dictionary<AnimationDefinitions, Animation> AnimationSet;

        public Vector2 Position;//TODO move to physics component?
        public float Rotation;

        EntityStateBase CurrentState;

        public Entity(Vector2 position, Dictionary<AnimationDefinitions, Animation> animationSet)
        {
            this.Position = position;
            this.AnimationSet = animationSet;
        }

        public void Update(GameTime gameTime)
        {
            Brain.Update(gameTime);
        }

        public EntityRenderInfo GetRenderInfo()
        {
            var currentFrame = CurrentState.GetCurrentRenderableFrame();
            return new EntityRenderInfo(
                Position,
                currentFrame.Origin,
                currentFrame.Texture);
        }

        public void Initialize(EntityStateBase initialState, BrainComponentBase brain)
        {
            CurrentState = initialState;
            Brain = brain;
        }
    }
}
