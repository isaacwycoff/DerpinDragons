using DerpinDragons.Entities;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons.World
{
    //would control game directing logic, like determining win/lose condition, contains game direction specific info
    class Director
    {
        private Entity[] Players;

        public Director()
        {
            Players = new Entity[0];
        }

        public void SetPlayers(Entity[] players)
        {
            Players = players;
        }

        public void Update(GameTime gameTime)
        {
            //would do things like check if all players are dead
        }
    }
}
