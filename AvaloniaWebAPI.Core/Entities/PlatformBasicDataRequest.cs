using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaWebAPI.Core.Entities
{
    public class PlatformBasicDataRequest
    {
        public string DataMethod { get; set; }

        public int GroupID { get; set; }
        public int OuID { get; set; }
        public int ShopID { get; set; }
        public DateTime? ModifyDTM { get; set; } 

        public string? TableName { get; set; }
        
    }
}
