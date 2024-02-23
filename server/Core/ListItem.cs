using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ListItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int ListItemId { get; set; }
        public int ListId { get; set; }
        public string Title { get; set; }
        public string Information { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAT { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)] public DateTime UpdatedAt { get; set; }
    }
}
