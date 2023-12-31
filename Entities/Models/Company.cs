﻿
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Company
{
    [Column("CompanyId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Company name is required")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Company address is required")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Address is 60 characters")]
    public string? Address { get; set; }

    public string? Country { get; set; }

    public ICollection<Employee>? Employees { get; set; }
    //public ICollection<Attendance> Attendance { get; set; }

    /*public Company()
    {
        Attendance = new List<Attendance>();
    }*/
}
