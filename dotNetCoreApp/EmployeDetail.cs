using System;
using System.Collections.Generic;

namespace dotNetCoreApp;

public partial class EmployeDetail
{
    public int EmployeeId { get; set; }

    public string? Email { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string? Department { get; set; }

    public string? Designation { get; set; }

    public decimal? Salary { get; set; }
}
