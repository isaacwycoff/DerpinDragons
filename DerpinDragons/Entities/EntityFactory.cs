using DerpinDragons.Entities.Brains;
using DerpinDragons.Entities.States;
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
            
            var entity = new Entity(position, ContentService.DerpyDwarfAnimationSet);//, playerStartState);//TODO yeah yeah it's not done yet, just getting the patterns out there
            var playerBrain = new PlayerBrain(entity);
            var playerStartState = new ProtoIdleState(entity);// new PlayerIdleState(null);

            entity.Initialize(playerStartState, playerBrain);

            return entity;
        }
    }
}
