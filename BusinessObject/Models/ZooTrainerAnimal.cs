﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessObject.Models
{
    public partial class ZooTrainerAnimal
    {
        [Key]
        [Column("id")]
        [StringLength(2)]
        public string Id { get; set; }
        [Required]
        [StringLength(50)]
        public string UserId { get; set; }
        [Required]
        [Column("Animal_ID")]
        [StringLength(50)]
        public string AnimalId { get; set; }
        [Column("Food_ID")]
        [StringLength(50)]
        public string FoodId { get; set; }
        [StringLength(50)]
        public string Date { get; set; }
        [Required]
        [Column("status")]
        [StringLength(50)]
        public string Status { get; set; }

        [ForeignKey("AnimalId")]
        [InverseProperty("ZooTrainerAnimal")]
        public virtual Animal Animal { get; set; }
        [ForeignKey("FoodId")]
        [InverseProperty("ZooTrainerAnimal")]
        public virtual Food Food { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("ZooTrainerAnimal")]
        public virtual User User { get; set; }
    }
}