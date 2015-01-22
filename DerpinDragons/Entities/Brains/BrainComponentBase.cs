using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons.Entities.Brains
{
    public abstract class BrainComponentBase
    {
        protected Entity Context;

        public BrainComponentBase(Entity context)
        {
            this.Context = context;
        }

        public abstract void Update(GameTime gameTime);
    }
}
