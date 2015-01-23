using DerpinDragons.Entities.Brains;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DerpinDragons.Services;

namespace DerpinDragons.Entities
{
    public class EntityFactory
    {
        public static Entity CreatePlayer(Vector2 position)
        {
            var entity = new Entity(position, ContentService.DerpyDwarfAnimationSet, ContentService.DerpyDwarf);//, playerStartState);//TODO yeah yeah it's not done yet, just getting the patterns out there
            var playerBrain = new PlayerBrain(entity);

            entity.Initialize(playerBrain);

            return entity;
        }
    }
}
