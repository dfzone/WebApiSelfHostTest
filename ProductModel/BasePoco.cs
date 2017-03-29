using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductModel
{
    public abstract class BasePoco
    {
        [Key]
        public Guid ID { get; set; }

        [StringLength(100)]
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }

        [StringLength(100)]
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
