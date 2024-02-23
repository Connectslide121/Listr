using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class ListDTO
    {
        public int ListId { get; set; }
        public string ListName { get; set; }
        public List<ListItemDTO> ListItemDTOs { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
