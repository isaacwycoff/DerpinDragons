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

        public BrainComponentBase()
        { }

        public void Sire(Entity entity)
        {
            this.Context = entity;
        }

        public abstract void Update(GameTime gameTime);
    }
}
