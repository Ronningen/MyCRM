using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMCore
{
    public interface IDeletableEntity
    {
        bool Deleted { get; set; }
    }
}
