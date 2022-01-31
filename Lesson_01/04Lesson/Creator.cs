using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons._04Lesson
{
    public sealed class Сreator
    {
        private static Hashtable ht_buildings = new Hashtable();
        public static Hashtable Buildings { get => ht_buildings;  }

        private Сreator() { }


        public static Building CreateBuild()
        {
            Building building = new Building()
            {
                High = 10,
                Floor = 0,
                Apartments = 0,
                Entrances = 0,
            };
            ht_buildings.Add(building.Number, building);
            return building;
        }
        public static Building CreateBuild(float high, uint floor, uint apartments, uint entrances)
        {
            Building building = new Building()
            {
                High = high,
                Floor = floor,
                Apartments = apartments,
                Entrances = entrances,
            };
            ht_buildings.Add(building.Number, building);
            return building;
        }
        public static void DeleteBuild(int number)
        {
            if (ht_buildings.ContainsKey(number))
            {
                Building.ClearBuild(number);
                ht_buildings.Remove(number);
            }

        }
    }
}
