using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class DataService2 : IDataService2
    {
        private IList<double> _beursprijzen;
        public DataService2()
        {
            _beursprijzen = new List<double>();
            _beursprijzen.Add(2.5);
            _beursprijzen.Add(3.8);
            _beursprijzen.Add(5.7);
        }

        public IList<double> GeefAllePrijzen()
        {
            return _beursprijzen;
        }
    }
}
