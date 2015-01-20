using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons.Utilities
{
    class TickTimer
    {
        private int StartMilli;

        public TimeSpan CurrentCountdown { get; private set; }
        
        public bool IsComplete
        {
            get { return CurrentCountdown <= TimeSpan.Zero;}
        }
        
        public float Progress
        {
            get { return StartMilli == 0 ? 0 : (float)(CurrentCountdown.TotalMilliseconds / StartMilli); }
        }

        public TickTimer(int milli)
        {
            StartMilli = milli;
            CurrentCountdown = TimeSpan.FromMilliseconds(milli);
        }

        public void Update(GameTime gameTime)
        {
            CurrentCountdown -= gameTime.ElapsedGameTime;
        }

        public void Reset()
        {
            CurrentCountdown = TimeSpan.FromMilliseconds(StartMilli);
        }

        public void Reset(int milli)
        {
            StartMilli = milli;
            CurrentCountdown = TimeSpan.FromMilliseconds(milli);
        }

        public static TickTimer Expired { get { return new TickTimer(0); } }
    }
}
