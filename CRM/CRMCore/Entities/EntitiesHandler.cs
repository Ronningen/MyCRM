using System;

namespace CRMCore.Entities
{
    public partial class EntitiesHandler
    {
        public CRMContext Entities { get; private set; }

        public event Action DataGetFailed;
        public event Action DataSaveFailed;

        public static EntitiesHandler entitiesHandler { get; private set; }

        public static EntitiesHandler CreateEntitiesHandler()
        {
            if (entitiesHandler == null)
                entitiesHandler = new EntitiesHandler();
            return entitiesHandler;
        }

        private EntitiesHandler()
        {
            DefineEvents();
        }

        partial void DefineEvents();

        public void Load()
        {
            try
            {
                Entities = new CRMContext();
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
