using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Structs
{
    public struct FireWeaponTo
    {
        public static readonly Byte Type = 21;
        public Int32 _target1;
        public Int32 _target2;
        public Byte _weapon;

        public FireWeaponTo(Int32 Target1, Int32 Target2, Byte Weapon)
        {
            _target1 = Target1;
            _target2 = Target2;
            _weapon = Weapon;
        }
    }

}
