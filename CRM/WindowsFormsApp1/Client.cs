namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client : CRMCore.IDeletableEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string SecondName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(12)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public bool Deleted { get; set; }
    }
}
