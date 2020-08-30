﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    [Table("MembershipTypes")]
    public class MembershipType
    {
        public byte Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonth { get; set; }
        public byte DiscountRate { get; set; }
    }
}
