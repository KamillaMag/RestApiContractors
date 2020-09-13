using System.Collections.Generic;

namespace LibContractors
{
    public interface IContractorsRepository
    {
        IEnumerable<Contractor> GetAll();
        int Create(Contractor contractor);
    }
}