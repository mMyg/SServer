using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Objects
{
    public class Infantry
    {
        public Int32 _speed;
        public Int32 _secondaryweapon;
        public Int32 _primaryweapon;
        public Int32 _owners;
        public Int32 _buildlevel;
        public Int32 _cost;
        public Int32 _sight;
        public Int32 _hitpoints;
        public Int32 _ammo;
        public Int32 _infiltrate;
        public Int32 _iswanderer;
        public Int32 _hidetruename;
        public Int32 _iscivilian;
        public Int32 _prerequisites;
        public Int32 _techlevel;
        public String _namestring;
        public Int32 _namestringid;
        public Int32 _unitid;

        public Infantry(Int32 Speed, Int32 SeconardayWeapon, Int32 PrimaryWeapon, Int32 Owners, Int32 BuildLevel,
         Int32 Cost, Int32 Sight, Int32 HitPoints, Int32 Ammo, Int32 Infiltrate, Int32 IsWanderer, Int32 HideTrueName,
         Int32 IsCivilian, Int32 Prerequisites, Int32 TechLevel, String NameString, Int32 NameStringId, Int32 UnitId)
        {
            _speed = Speed;
            _secondaryweapon = SeconardayWeapon;
            _primaryweapon = PrimaryWeapon;
            _owners = Owners;
            _buildlevel = BuildLevel;
            _cost = Cost;
            _sight = Sight;
            _hitpoints = HitPoints;
            _ammo = Ammo;
            _infiltrate = Infiltrate;
            _iswanderer = IsWanderer;
            _hidetruename = HideTrueName;
            _iscivilian = IsCivilian;
            _prerequisites = Prerequisites;
            _techlevel = TechLevel;
            _namestring = NameString;
            _namestringid = NameStringId;
            _unitid = UnitId;
        }
    }
}
