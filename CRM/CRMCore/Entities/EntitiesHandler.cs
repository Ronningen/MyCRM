using System;

namespace CRMCore.Entities
{
    /// <summary>
    /// Provides tools to run DataContext
    /// </summary>
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

        /// <summary>
        /// Try to load data from database. If fails, invokes DataGetFailed.
        /// </summary>
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

        /// <summary>
        /// Try to save changes in dataSet to database. If fails, invokes DataSaveFailed.
        /// </summary>
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
