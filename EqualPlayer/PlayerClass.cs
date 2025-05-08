using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqualPlayer
{
    public class Player
    {


        public enum PlayerClass
        {
            Tank, Fighter, Slayer, Mage,
            Controller, Marksmen
        }

        public PlayerClass PClass { get; }
        public string Name { get; }
        public Player(PlayerClass pClass, string name)
        {
            PClass = pClass;
            Name = name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Player otherPlayer)
            {
                return PClass == otherPlayer.PClass && Name == otherPlayer.Name;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return PClass.GetHashCode() ^ Name.GetHashCode();
        }
    }
}