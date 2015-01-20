using DerpinDragons.Utilities;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons.Entities.Animations
{
    class Animation
    {
        private AnimationFrame[] AnimationFrames;
        private TickTimer FrameTimer;
        private int FrameCount;
        private int FrameIndex;

        public Animation(AnimationFrame[] animationFrames)
        {
            AnimationFrames = animationFrames;
            FrameTimer = new TickTimer(AnimationFrames[0].FrameTimeMilli);
            FrameIndex = 0;
            FrameCount = AnimationFrames.Count();
        }

        public void Update(GameTime gameTime)
        {
            FrameTimer.Update(gameTime);
            if (FrameTimer.IsComplete)
            {
                FrameIndex = (FrameIndex + 1) % FrameCount;
                FrameTimer.Reset(AnimationFrames[FrameIndex].FrameTimeMilli);
            }
        }

        public AnimationFrame GetCurrentFrame()
        {
            return AnimationFrames[FrameIndex];
        }
    }
}
