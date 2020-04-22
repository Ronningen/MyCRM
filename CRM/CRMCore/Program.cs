using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CRMCore.Entities;

namespace CRMCore
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run((Patterns.PatternEntityForm<A>)(Patterns.EntityFormMode.Add));
        }
    }

    class A : IViewEntity
    {
        public string ViewName => "a a";

        public Dictionary<string, EntityProperty> EnitiesViewProperties => throw new NotImplementedException();
    }
}
