using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vissoft.Core.Helper
{
    public interface IDateTracking
    {
        DateTime CreatedDate { get; set; }
        DateTime? LastModifiedDate { get; set; }
    }
}
