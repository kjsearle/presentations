﻿// Copyright Information
// ==================================
// AutoLot - AutoLot.Models - Person.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2020/12/13
// ==================================

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AutoLot.Models.Entities.Owned
{
    [Owned]
    public class Person
    {
        [Required, StringLength(50)] 
        public string FirstName { get; set; } = "New";

        [Required, StringLength(50)] 
        public string LastName { get; set; } = "Customer";

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string FullName { get; set; }
    }
}