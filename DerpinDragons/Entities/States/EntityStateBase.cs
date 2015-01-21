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

        protected EntityStateBase(EntityStateBase previousState)
        {
            if (previousState != null)
            {
                Context = previousState.Context;
            }
        }

        public abstract AnimationDefinitions GetCurrentAnimation();

        public RenderableFrameForDirection GetCurrentRenderableFrame()
        {
            return CurrentAnimation.GetCurrentFrame().GetRenderableFrameForDirection(Context.Rotation);
        }
    }
}
