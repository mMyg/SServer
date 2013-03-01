using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Enums
{
    public enum Event
    {
        None,
        PlayerEnters,
        Discovered,
        Attacked,
        Destroyed,
        HouseDiscov,
        UnitsDestr,
        BldgsDestr,
        AllDestr,
        Credits,
        Time,
        NumBldgsDstr,
        NumUnitsDstr,
        NoFactories,
        CivEvac,
        BuiltIt
    };
}
