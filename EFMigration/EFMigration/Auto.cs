using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMigration
{
    [Table("Auto")]
    public class Auto
    {
        [Key]
        public int Id { get; set; }
        public string Gyartmany { get; set; }
        public int GyartasiEv { get; set; }
    }
}
