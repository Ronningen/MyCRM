using System;

namespace CRMCore.Entities
{
    public partial class EntitiesHandler
    {
        public CRMContext Entities { get; private set; }

        public event Action DataGetFailed;
        public event Action DataSaveFailed;

        private static EntitiesHandler handler;
        public static EntitiesHandler Handler
        {
            get
            {
                if (handler == null)
                    handler = new EntitiesHandler();
                return handler;
            }
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
