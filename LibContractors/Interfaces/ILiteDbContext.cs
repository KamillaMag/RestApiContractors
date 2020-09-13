using LiteDB;
namespace LibContractors
{
    public interface ILiteDbContext
    {
        public LiteDatabase Database { get; }
    }
}