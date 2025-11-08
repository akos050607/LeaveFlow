using System;
using System.Collections.Generic;

namespace LeaveFlowAPI.Models;

public partial class LeaveRequest
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string RequestType { get; set; } = null!;

    public string Status { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
