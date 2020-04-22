using System;
using System.Data.Entity;

namespace CRMCore.Entities
{
    class EntitiesHandler<TEntities> where TEntities : DbContext, new()
    {
        public TEntities Entities { get; private set; }

        public event Action DataGetFailed;
        public event Action DataSaveFailed;

        public EntitiesHandler(Action dataGetFailedHandler)
        {
            DataGetFailed += dataGetFailedHandler;
            try
            {
                Entities = new TEntities();
            }
            catch
            {
                DataGetFailed();
            }
        }

        public void Save()
        {
            try
            {
                Entities.SaveChanges();
            }
            catch
            {
                DataSaveFailed();
            }
        }
    }
}
