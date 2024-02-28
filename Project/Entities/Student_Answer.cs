﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Entities;

[PrimaryKey("Question_ID", "Student_ID")]
[Table("Student_Answer")]
public partial class Student_Answer
{
    public int Exam_ID { get; set; }

    [Key]
    public int Question_ID { get; set; }

    [Key]
    public int Student_ID { get; set; }

    [Column("Student_Answer")]
    [StringLength(200)]
    [Unicode(false)]
    public string Student_Answer1 { get; set; }

    [ForeignKey("Exam_ID")]
    [InverseProperty("Student_Answers")]
    public virtual Exam Exam { get; set; }

    [ForeignKey("Question_ID")]
    [InverseProperty("Student_Answers")]
    public virtual Question Question { get; set; }

    [ForeignKey("Student_ID")]
    [InverseProperty("Student_Answers")]
    public virtual Student Student { get; set; }
}