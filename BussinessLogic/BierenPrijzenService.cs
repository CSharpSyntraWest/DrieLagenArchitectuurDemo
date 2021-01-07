using DataAccessLayer;
using System;
using System.Collections.Generic;

namespace BussinessLogic
{

    public class BierenPrijzenService
    {
        private IDictionary<string, double> _bierprijzen;
        private IDataService _bierenNamendata;
        private IDataService2 _bierenPrijzendata;
        public BierenPrijzenService()
        {
            _bierenNamendata = new DataService();
            _bierenPrijzendata = new DataService2();
            _bierprijzen = new Dictionary<string, double>();
        }
        public IDictionary<string, double> GeefBierenMetPrijzen()
        {
           IList<string> biernamen =  _bierenNamendata.GeefAlleBiernamen();
           IList<double> bierprijzen = _bierenPrijzendata.GeefAllePrijzen();
            //validatie: bv zijn beide lijsten even groot, zijn alle prijzen beschikbaar,..
            for (int i = 0; i < biernamen.Count; i++)
            {
                _bierprijzen.Add(biernamen[i], bierprijzen[i]);
            }
            return _bierprijzen;
        }
    }
}
