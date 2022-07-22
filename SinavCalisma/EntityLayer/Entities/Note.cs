using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string tkg_note { get; set; } // taking note

        public ICollection<User> Users { get; set; }

    }
}
