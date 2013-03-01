using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Database
{
    public class Scenarios
    {
        private List<String> _records;

        public Scenarios()
        {
            _records = new List<String>();
            _records.Add("SCS01EA");
            _records.Add("SCS02EA");
            _records.Add("SCS03EA");
            _records.Add("SCS10EA");
            _records.Add("SCS11EA");
            _records.Add("SCS12EA");
            _records.Add("SCS14EA");
            _records.Add("SCS15EA");
            _records.Add("SCS16EA");
            _records.Add("SCS17EA");
            _records.Add("SCS30EA");
            _records.Add("SCS31EA");
            _records.Add("SCS32EA");
            _records.Add("SCS33EA");
            _records.Add("SCS35EA");
            _records.Add("SCS36EA");
            _records.Add("SCS37EA");
            _records.Add("SCS38EA");
            _records.Add("SCS39EA");
            _records.Add("SCS40EA");
            _records.Add("SCS41EA");
            _records.Add("SCS42EA");
            _records.Add("SCS43EA");
            _records.Add("SCS50EA");
            _records.Add("SCS51EA");
            _records.Add("SCS60EA");
            _records.Add("SCS61EA");
            _records.Add("SCS62EA");
            _records.Add("SCS63EA");
        }

        public Int32 GetRecordCount()
        {
            return _records.Count;
        }

        public String GetScenarioByIndex(Int32 Index)
        {
            return _records[Index];
        }
    }
}
