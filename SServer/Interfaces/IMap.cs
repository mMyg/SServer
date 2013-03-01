using System;
using System.Collections.Generic;
using System.Text;
using SServer.Objects;

namespace SServer.Interfaces
{
    public interface IMap
    {
        void PlaceUnit(Unit Unit);
        void RemoveUnit(Unit Unit);
        Boolean MoveUnit(Cell Start, Cell End);
        List<Unit> GetUnits();
        void ClearUnits();
        Cell[,] GetCells();
        UInt32 GetScenarioNumber();
    }
}
