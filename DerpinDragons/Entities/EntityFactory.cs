using DerpinDragons.Entities.Brains;
using DerpinDragons.Services;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons.Entities
{
    public class EntityFactory
    {
        public static Entity CreatePlayer(Vector2 position)
        {
            var playerBrain = new PlayerBrain();
            var entity = new Entity(ContentService.DerpyDwarf, playerBrain, position, new Vector2(6, 6));//TODO yeah yeah it's not done yet, just getting the patterns out there

            return entity;
        }
    }
}
