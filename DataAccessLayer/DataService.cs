using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class DataService : IDataService
    {
        private IList<string> _biernamen;
        public DataService()
        {
            _biernamen = new List<string>();
            _biernamen.Add("Leffe Blond");
            _biernamen.Add("Grimbergen Blond");
            _biernamen.Add("Heineken pils");
        }

        public IList<string> GeefAlleBiernamen()
        {
            return _biernamen;
        }
    }
}
