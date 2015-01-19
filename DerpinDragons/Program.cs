using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerpinDragons
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var game = new DerpinGame())
            {
                game.IsMouseVisible = true;
                game.Run();
            }
        }

    }
}
