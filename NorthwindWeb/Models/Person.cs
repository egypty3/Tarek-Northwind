namespace NorthwindWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    /// <summary>
    /// The entity that contains information about persons, located in database.
    /// </summary>
    [Table("Person")]
    public partial class Person
    {

        /// <summary>
        /// The ID through which we find the person.
        /// </summary>
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        /// <summary>
        /// The LastName through which we find the person.
        /// </summary>
        [Key]
        [Required(ErrorMessage = "Enter your name")]
        [Column(Order = 1)]
        [StringLength(255)]
        public string LastName { get; set; }

        /// <summary>
        /// The FirstName through which we find the person.
        /// </summary>
        [StringLength(255)]
        public string FirstName { get; set; }

        /// <summary>
        /// The Email through which we find the person.
        /// </summary>
        [Required(ErrorMessage = "Email was not entered correctly")]
        [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; }

        /// <summary>
        /// The Comment what belongs to the person.
        /// </summary>
        [Required(ErrorMessage = "Please give your opinion")]
        [StringLength(255)]
        public string Comment { get; set; }

    }
}
