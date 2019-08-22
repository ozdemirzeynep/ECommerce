using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.DTO
{
    public class AjaxResponseDto
    {
        public Guid AjaxResponseUid = Guid.NewGuid();
        public dynamic Dynamic { get; set; }
    }
}
