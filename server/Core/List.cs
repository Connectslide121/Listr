using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class List
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int ListId { get; set; }
        public string ListName { get; set; }
        public List<ListItem> ListItems { get; set; }
        public DateTime CreatedAT { get; set; }
    }
}
