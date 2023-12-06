using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VissSoft.Core.Helper
{
    public class BaseEntity
    {
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public int? createdBy { get; set; }
        public int? updatedBy { get; set; }
        public bool status { get; set; }
    }
}
