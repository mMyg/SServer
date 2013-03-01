using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SServer.IO;
using SServer.Interfaces;

namespace SServer.Objects
{
    public class Unit
    {
        public Vehicle _vehicle;
        public Infantry _infantry;
        public Byte _unitslot;
        public String _name;
        public Byte _magicnumber;
        public Byte _house;
        public Byte _class;
        public Byte _type;
        private Int32 _team;
        private Int32 _score;
        private Byte _spectator;
        private Int16 _health;
        private Byte _stealth;
        private Byte _armour;
        private Byte _firepower;
        private Byte _speed;
        private Byte _reload;
        private Byte _range;
        private Cell _cell;

        public Cell GetCell()
        {
            return _cell;
        }
        
        public String GetName()
        {
            return _name;
        }

        public Byte GetMagicNumber()
        {
            return _magicnumber;
        }

        public Byte GetClass()
        {
            return _class;
        }

        public Int32 GetUnitId()
        {
            return (_class << 0x0E) + _unitslot;
        }

        public Byte GetUnitSlot()
        {
            return _unitslot;
        }

        public Byte GetHouse()
        {
            return _house;
        }

        public new Byte GetType()
        {
            return _type;
        }

        public Int32 GetTeam()
        {
            return _team;
        }

        public Int32 GetScore()
        {
            return _score;
        }

        public Byte GetSpectator()
        {
            return _spectator;
        }

        public Int16 GetHealth()
        {
            return _health;
        }

        public Int16 GetStartingHealth()
        {
            if (_vehicle != null)
            {
                return (Int16)_vehicle._hitpoints;
            }
            if (_infantry != null)
            {
                return (Int16)_infantry._hitpoints;
            }
            return 0;
        }

        public Byte GetStealth()
        {
            return _stealth;
        }

        public Byte GetArmour()
        {
            return _armour;
        }

        public Byte GetFirePower()
        {
            return _firepower;
        }

        public Byte GetRange()
        {
            return _range;
        }

        public Byte GetReload()
        {
            return _reload;
        }

        public Byte GetSpeed()
        {
            return _speed;
        }

        public void SetCell(Cell Cell)
        {
            _cell = Cell;
        }

        public void SetUnitSlot(Byte B)
        {
            _unitslot = B;
        }

        public void SetName(String S)
        {
            _name = S;
        }

        public void SetMagicNumber(Byte B)
        {
            _magicnumber = B;
        }

        public void SetHouse(Byte B)
        {
            _house = B;
            _team = B - 4;
        }
   
        public void SetClass(Byte B)
        {
            _class = B;
        }
        
        public void SetType(Byte B)
        {
            _type = B;
        }

        public void SetTeam(Int32 I)
        {
            _team = I;
        }

        public void SetScore(Int32 I)
        {
            _score = I;
        }

        public void SetSpectator(Byte B)
        {
            _spectator = B;
        }

        public void SetUnitType(Vehicle Vehicle)
        {
            _vehicle = Vehicle;
        }

        public void SetUnitType(Infantry Infantry)
        {
            _infantry = Infantry;
        }

        public void SetHealth(Int16 I)
        {
            _health = I;
        }

        public void SetStealth(Byte B)
        {
            _stealth = B;
        }

        public void SetArmour(Byte B)
        {
            _armour = B;
        }

        public void SetFirePower(Byte B)
        {
            _firepower = B;
        }

        public void SetRange(Byte B)
        {
            _range = B;
        }

        public void SetReload(Byte B)
        {
            _reload = B;
        }

        public void SetSpeed(Byte B)
        {
            _speed = B;
        }
    }
}
