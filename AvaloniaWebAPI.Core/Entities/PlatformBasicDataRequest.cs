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
         
        //public string OuCode { get; set; }
        //public string ShopCode { get; set; }
        //public int Status { get; set; }
        //public int SkipCount { get; set; }
        //public int MaxResultCount { get; set; }
        public DateTime? ModifyDTM { get; set; } 

        public string? TableName { get; set; }
        
    }
}
