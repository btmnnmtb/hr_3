using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr_3
{
    internal class Car
    {
        public int CarId;
        public int CarGodId;
        public int CarGod { get; private set; }
        public string CarName { get; private set; }
        public Car(table_222 tab)
        {
            CarId = tab.id_table_22;
            CarGod = (int)tab.car_god_proizvod;
            if (tab.table_111 != null)
            {
                CarGodId = tab.table_111.id_table_11;
                CarName = tab.table_111.car_name;
            }

        }


    }
}
