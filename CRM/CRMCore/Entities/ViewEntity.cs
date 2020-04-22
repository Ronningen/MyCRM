using System;
using System.Collections.Generic;

namespace CRMCore.Entities
{
    public interface IViewEntity
    {
        Dictionary<string, EntityProperty> EnitiesViewProperties { get; }
    }

    public struct EntityProperty
    {
        public Func<object> getFormatedToView;
        public Predicate<object> isRightFormatted;
        public string formatMessege;

        public EntityProperty(Func<object> getFormatedToView, Predicate<object> isRightFormatted, string formatMessege)
        {
            this.getFormatedToView = getFormatedToView;
            this.isRightFormatted = isRightFormatted;
            this.formatMessege = formatMessege;
        }
    }

    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Property)]
    public class NameAttribute : Attribute
    {
        public string Name { get; private set; }
        public NameAttribute(string name) => Name = name;
    }
}
