using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface IDataService
    {
        IList<string> GeefAlleBiernamen();
    }
}