﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Entities;

[Table("Department")]
public partial class Department
{
    [Key]
    public int Dept_ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Dept_Name { get; set; }

    [InverseProperty("Dept")]
    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();

    [InverseProperty("Dept")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}