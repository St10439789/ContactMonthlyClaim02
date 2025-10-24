using System;
using System.ComponentModel.DataAnnotations;

namespace ContactMonthlyClaim02.Models
{
    public class Claim
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string LecturerName { get; set; }

        [Required]
        public string ClaimDescription { get; set; }

    
        public string Status { get; set; } = "Pending";
        public DateTime DateSubmitted { get; set; } = DateTime.Now;

        // Optional tracking fields
        public DateTime? DateApproved { get; set; }
        public DateTime? DateRejected { get; set; }
        public string? Comments { get; set; }
    }
}

