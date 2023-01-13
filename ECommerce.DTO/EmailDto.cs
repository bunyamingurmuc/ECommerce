using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DTO
{
    public class EmailDto
    {
        public string? fromSend { get; set; }
        public string? toSend { get; set; }
        public string? body { get; set; }
        public string? subject { get; set; }
    }
}
