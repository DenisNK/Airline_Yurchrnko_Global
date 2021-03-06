﻿using System.ComponentModel.DataAnnotations;
using Airline.DAL.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Airline.DAL.Models
{
    public class Navigator : BaseId, IEntity
    {
        [Required(ErrorMessage = "Please, input your name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name should not be longer than 20 characters.")]
        public string Name { get; set; }

        //[Remote("ValidateJsonResultTitle", "Navigators")]
        [Required(ErrorMessage = "Please, input your surname")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name should not be longer than 20 characters.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please, input the Age")]
        [Range(18, 75)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please, input the experience(year)")]
        [Range(1, 45)]
        public int Experience { get; set; }

        [Required(ErrorMessage = "Please, input the salary ($)")]
        [Range(100, 5000)]
        public int Salary { get; set; }
        
        // [ForeignKey("Team_PersonId")]   if we use DataAnnotations
        public int? Team_PersonId { get; set; }
        public virtual Team_Person Team_Person { get; set; }
    }
}
