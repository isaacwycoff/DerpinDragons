using DerpinDragons.Entities.Animations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons.Entities.States
{
    public class ProtoIdleState : EntityStateBase
    {
        public ProtoIdleState(Entity context)
            :base(context)
        {
        }

        public ProtoIdleState(EntityStateBase previousState)
            :base(previousState)
        {
        }

        public override AnimationDefinitions GetCurrentAnimation()
        {
            return AnimationDefinitions.Idle;
        }
    }
}
