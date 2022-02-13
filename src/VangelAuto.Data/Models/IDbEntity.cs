using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VangelAuto.Data.Models
{
    public interface IDbEntity
    {
        public int Id { get; set; }
    }
}
