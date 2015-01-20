using DerpinDragons.Entities.Animation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons.Entities.States
{
    //does animation behind the scenes
    abstract class EntityStateBase
    {
        protected Entity Context;
        protected Animation

        protected EntityStateBase(EntityStateBase previousState)
        {
            Context = previousState.Context;
        }

        protected EntityStateBase(Entity context)
        {
            Context = context;
        }

        public abstract Animations GetCurrentAnimation
    }
}
