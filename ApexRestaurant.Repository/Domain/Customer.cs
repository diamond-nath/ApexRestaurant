using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApexRestaurant.Repository.Domain
{
    public class Customer
    {
         [Column("id")]
         [Key]
        public int Id { get; set; }

         [Column("first_name")]
        public string FirstName { get; set; }
        
         [Column("last_name")]
        public string LastName { get; set; }
        
         [Column("address")]
        public string Address  { get; set; }

         [Column("phone_res")]
        public string PhoneRes { get; set; }

         [Column("phone_mob")]
        public string PhoneMob { get; set; }

         [Column("enroll_date")]
        public DateTime EnrollDate { get; set; }

         [Column("is_active")]
        public bool IsActive { get; set; } = true;

         [Column("created_by")]
        public string CreatedBy { get; set; }

         [Column("created_on")]
        public DateTime CreatedOn { get; set; } = DateTime.Now;

         [Column("updated_by")]
        public string? UpdatedBy { get; set; }

         [Column("updated_on")]
        public DateTime? UpdatedOn { get; set; }

    }
}