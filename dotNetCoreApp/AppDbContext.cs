using System;
using Microsoft.EntityFrameworkCore;

namespace dotNetCoreApp.DataBase;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<EmployeeDetail> EmployeDetails { get; set; }
}

public class EmployeeDetail
{
    public int EmployeeID { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Department { get; set; }
    public string? Designation { get; set; }
    public decimal Salary { get; set; }
}

