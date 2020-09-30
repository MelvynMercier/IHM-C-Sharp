using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    [Table("Contacts")]
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { set; get; }
        [Column("first_name")]
        public string FirstName { set; get; }
        [Column("last_name")]
        public string LastName { set; get; }
        [Column("date_of_birth")]
        public DateTime? DateOfBirth { set; get; }
        [Column("email")]
        public string Email { set; get; }
        [Column("campagne_id")]
        public int CampagneId { set; get; }
        public Campagne Campagne { set; get; }
    }
}
