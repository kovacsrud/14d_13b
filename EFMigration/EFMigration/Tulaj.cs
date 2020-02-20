using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMigration
{
    [Table("Tulaj")]
    public class Tulaj
    {
        [Key]
        public int Id { get; set; }
        public string Vezeteknev { get; set; }
        public string Keresztnev { get; set; }
        public int SzuletesiEv { get; set; }
        public virtual Auto auto { get; set; }
    }
}
