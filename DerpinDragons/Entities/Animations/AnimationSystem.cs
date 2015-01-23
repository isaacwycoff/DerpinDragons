using DerpinDragons.Utilities;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons.Entities.Animations
{
    public class AnimationSystem
    {
        private AnimationFrame[][] Animations;
        private AnimationFrame[] CurrentAnimation;
        private TickTimer FrameTimer;
        private int FrameCount;
        private int FrameIndex;

        public AnimationSystem(AnimationFrame[][] animationDefinitions)
        {
            Animations = animationDefinitions;
            CurrentAnimation = Animations[(int)AnimationDefinitions.Idle];

            FrameTimer = new TickTimer(CurrentAnimation[0].FrameTimeMilli);  
            FrameIndex = 0;
            FrameCount = CurrentAnimation.Count();
        }

        public void Update(GameTime gameTime)
        {
            FrameTimer.Update(gameTime);
            if (FrameTimer.IsComplete)
            {
                FrameIndex = (FrameIndex + 1) % FrameCount;
                FrameTimer.Reset(CurrentAnimation[FrameIndex].FrameTimeMilli);
            }
        }

        public void ChangeAnimation(AnimationDefinitions animation)
        {
            CurrentAnimation = Animations[(int)animation];
        }

        public AnimationFrame GetCurrentFrame()
        {
            return CurrentAnimation[FrameIndex];
        }
    }
}
