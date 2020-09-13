using LiteDB;
using System.Collections.Generic;

namespace LibContractors
{
    public class ContractorsRepository : IContractorsRepository
    {
        private LiteDatabase _liteDb;
        public ContractorsRepository(ILiteDbContext liteDbContext)
        {
            _liteDb = liteDbContext.Database;
        }
        public int Create(Contractor contractor)
        {
            var collection = _liteDb.GetCollection<Contractor>("Contractors");
            if (collection.FindOne(x => x.INN == contractor.INN && x.Name == contractor.Name) == null)
            {
                return collection.Insert(contractor);
            }
            else
            {
                return (int)Error.AlreadyExist;
            }
        }

        public IEnumerable<Contractor> GetAll()
        {
            return _liteDb.GetCollection<Contractor>("Contractors")
            .FindAll();
        }
    }
}