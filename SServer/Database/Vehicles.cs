using System;
using System.Collections.Generic;
using System.Text;
using SServer.Objects;

namespace SServer.Database
{
    public class Vehicles
    {
        private List<Vehicle> _vehicles;

        public Vehicles()
        {
            _vehicles = new List<Vehicle>();
            _vehicles.Add(new Vehicle(5, 15, 1, 3, 13, 11, 9, 13, 1500, 4, 750, -1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 131072, 5, 7, "HTNK", 88, 0));
            _vehicles.Add(new Vehicle(5, 21, 1, 3, -1, 10, 9, 7, 800, 3, 450, -1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, 3, "MTNK", 87, 1));
            _vehicles.Add(new Vehicle(5, 27, 1, 3, -1, 9, 10, 5, 600, 3, 500, -1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, 2, "LTNK", 86, 2));
            _vehicles.Add(new Vehicle(5, 32, 1, 2, -1, 4, 10, 12, 900, 4, 250, -1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 15, 5, 3, "STNK", 85, 3));
            _vehicles.Add(new Vehicle(5, 21, 1, 3, -1, 6, 10, 9, 800, 5, 450, -1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 16, 4, 10, "FTNK", 84, 4));
            _vehicles.Add(new Vehicle(5, 27, 1, 2, -1, 7, 15, 1, 800, 5, 300, -1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 99, 9, "VICE", 585, 5));
            _vehicles.Add(new Vehicle(10, 21, 1, 2, -1, 16, 11, 5, 700, 4, 400, -1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 32768, 4, 3, "APC", 110, 6));
            _vehicles.Add(new Vehicle(5, 21, 1, 2, -1, 14, 11, 11, 800, 4, 400, -1, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 2095152, 7, 7, "MSAM", 92, 7));
            _vehicles.Add(new Vehicle(10, 27, 3, 2, -1, 16, 9, 5, 400, 4, 310, -1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, "JEEP", 94, 8));
            _vehicles.Add(new Vehicle(10, 36, 3, 2, -1, 16, 10, 5, 300, 4, 230, -1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 4, 2, "BGGY", 89, 9));
            _vehicles.Add(new Vehicle(5, 15, 3, 2, -1, -1, 11, 7, 1400, 3, 600, -1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 128, 2, 0, "HARV", 98, 10));
            _vehicles.Add(new Vehicle(2, 27, 1, 2, -1, 15, 10, 9, 450, 4, 350, -1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 7, "ARTY", 99, 11));
            _vehicles.Add(new Vehicle(5, 15, 1, 2, -1, 22, 10, 98, 750, 4, 300, 2, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 4, 7, 3, "MLRS", 100, 12));
            _vehicles.Add(new Vehicle(127, 32, 5, 2, -1, -1, 11, 99, 300, 3, 400, -1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 99, 63, "UNNAMED", 107, 13));
            _vehicles.Add(new Vehicle(5, 21, 1, 2, -1, -1, 11, 99, 600, 5, 110, -1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 99, 3, "MHQ", 93, 14));
            _vehicles.Add(new Vehicle(1, 11, 6, 3, -1, 17, 11, 99, 300, 5, 700, -1, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 99, 0, "BOAT", 156, 15));
            _vehicles.Add(new Vehicle(5, 15, 3, 2, -1, -1, 11, 15, 5000, 3, 600, -1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2097152, 7, 0, "MCV", 157, 16));
            _vehicles.Add(new Vehicle(10, 41, 3, 1, -1, 4, 10, 5, 500, 4, 210, -1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, "BIKE", 158, 17));
            _vehicles.Add(new Vehicle(5, 21, 1, 3, -1, 23, 8, 99, 0, 5, 500, -1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 99, 81, "TRIC", 217, 18));
            _vehicles.Add(new Vehicle(5, 21, 1, 3, -1, 24, 8, 99, 0, 5, 600, -1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 99, 82, "TREX", 216, 19));
            _vehicles.Add(new Vehicle(5, 41, 1, 3, -1, 24, 8, 99, 0, 5, 300, -1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 99, 84, "RAPT", 218, 20));
            _vehicles.Add(new Vehicle(5, 13, 1, 3, -1, 23, 8, 99, 0, 5, 800, -1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 99, 83, "STEG", 219, 21));
        }

        public Vehicle Get(String Name)
        {
            for (Int32 i = 0; i < _vehicles.Count; i++)
            {
                if (_vehicles[i]._namestring.ToLower() == Name.ToLower())
                {
                    return _vehicles[i];
                }
            }
            return null;
        }

        public Vehicle Get(Int32 StringId)
        {
            for (Int32 i = 0; i < _vehicles.Count; i++)
            {
                if (_vehicles[i]._namestringid == StringId)
                {
                    return _vehicles[i];
                }
            }
            return null;
        }

        public Vehicle Get(Byte UnitType)
        {
            for (Int32 i = 0; i < _vehicles.Count; i++)
            {
                Byte tempUnitId = (Byte)_vehicles[i]._unitid;
                if (tempUnitId == UnitType)
                {
                    return _vehicles[i];
                }
            }
            return null;
        }
    }
}
