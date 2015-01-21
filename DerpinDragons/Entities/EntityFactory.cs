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
            var playerStartState = new PlayerIdleState(null);
            var playerBrain = new PlayerBrain();
            var entity = new Entity(playerBrain, position, ContentService.DerpyDwarfAnimationSet, playerStartState);//TODO yeah yeah it's not done yet, just getting the patterns out there
            entity.InitializeState(playerStartState);

            return entity;
        }
    }
}
