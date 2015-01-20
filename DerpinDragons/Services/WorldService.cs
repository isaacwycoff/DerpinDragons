using DerpinDragons.Entities;
using DerpinDragons.World;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons.Services
{
    public class WorldService
    {
        private static WorldService Instance;

        private List<Entity> Entities;
        private List<Entity> NewEntities;
        private Director Director;

        private WorldService()
        {
            Entities = new List<Entity>();
            NewEntities = new List<Entity>();
            Director = new Director();
        }

        public static void Initialize()
        {
            Instance = new WorldService();
        }

        public static void GetIntersectingEntities(Rectangle query)
        {
            //TODO inefficient and physics not implemented yet
            //return Instance.Entities.Where(entity => entity.GetCollisionBox().Intersects(query));111
            throw new NotImplementedException();
        }

        public static void AddEntity(Entity entity)
        {
            Instance.NewEntities.Add(entity);
        }

        public static void Update(GameTime gameTime)
        {
            Instance.Entities.AddRange(Instance.NewEntities);
            Instance.NewEntities.Clear();

            foreach (var entity in Instance.Entities)
            {
                entity.Update(gameTime);
            }

            Instance.Director.Update(gameTime);
        }

        public static Entity[] GetEntitiesInViewableArea(Rectangle viewArea)
        {
            //TODO actually filter them instead of being DUMB!
            return Instance.Entities.ToArray();
        }

        public static void BeginGame()
        {
            var player = EntityFactory.CreatePlayer(new Vector2(200f));
            AddEntity(player);
            Instance.Director.SetPlayers(new[] { player });
        }
    }
}
