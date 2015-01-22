using DerpinDragons.Entities.Animations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons.Entities.States
{
    //does animation behind the scenes
    public abstract class EntityStateBase
    {
        protected Entity Context;
        protected Animation CurrentAnimation;

        protected EntityStateBase(Entity entity)
        {
            Context = entity;
            CurrentAnimation = Context.AnimationSet[GetCurrentAnimation()];
        }

        protected EntityStateBase(EntityStateBase previousState)
        {
            Context = previousState.Context;
            CurrentAnimation = Context.AnimationSet[GetCurrentAnimation()];
        }

        public abstract AnimationDefinitions GetCurrentAnimation();

        public RenderableFrameForDirection GetCurrentRenderableFrame()
        {
            return CurrentAnimation.GetCurrentFrame().GetRenderableFrameForDirection(Context.Rotation);
        }
    }
}
