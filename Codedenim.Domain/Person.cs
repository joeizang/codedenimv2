using System;
using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain
{
    public abstract class Person
    {
        //[Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        // [Required]
        [StringLength(50, ErrorMessage = "Middle name cannot be longer than 50 characters.")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        //[Required]
        [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Gender { get; set; }

        // [Required]
        [EmailAddress]
        //[Index(IsUnique = true)]
        [MaxLength(100)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        //[Required(ErrorMessage = "Your Phone Number is required")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Town Of Birth")]
        [StringLength(50)]
        public string TownOfBirth { get; set; }

        [Display(Name = "State of Origin")]
        [StringLength(50)]
        public string StateOfOrigin { get; set; }

        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Display(Name = "Country of Birth")]
        [StringLength(50)]
        public string CountryOfBirth { get; set; }

        public bool IsAcctive { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.DateTime)]
        public DateTimeOffset? DateOfBirth { get; set; }

        public int? Age
        {
            get
            {
                if (DateOfBirth != null)
                {
                    var t = DateTime.Now - DateTime.Parse(DateOfBirth.ToString());
                    return Age = (int)t.Days / 365;
                }
                return null;

            }
            set { }
        }

        [Display(Name = "Full Name")]
        public string UserName => LastName + " " + FirstName;

        [Display(Name = "Full Name")]
        public string FullName => LastName + " " + FirstName + " " + MiddleName;

        public byte[] Passport { get; set; }
        public string FileLocation { get; set; }


    }
}