using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons.Entities
{
    public struct EntityRenderInfo
    {
        public readonly Vector2 DrawPosition;
        public readonly Vector2 Origin;
        public readonly Texture2D Texture;

        public EntityRenderInfo(Vector2 drawPosition, Vector2 origin, Texture2D texture)
        {
            this.DrawPosition = drawPosition;
            this.Origin = origin;
            this.Texture = texture;
        }
    }
}
