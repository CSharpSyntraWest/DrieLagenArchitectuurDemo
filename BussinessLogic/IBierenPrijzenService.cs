using System.Collections.Generic;

namespace BussinessLogic
{
    public interface IBierenPrijzenService
    {
        IDictionary<string, double> GeefBierenMetPrijzen();
    }
}