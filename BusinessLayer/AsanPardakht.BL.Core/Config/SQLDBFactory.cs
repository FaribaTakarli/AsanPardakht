using AsanPardakht.DAL.SQL;


namespace AsanPardakht.BL.Core
{
    internal class SQLDBFactory : IDBFactory
    {
         public object GetDB()
        {
            return new UnitOfwork();
        }
    }
}
