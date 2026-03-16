using System;
using System.Collections.Generic;

namespace APIEFCoreCRUD.Modelss;

public partial class EmployeeAudit
{
    public int? Empid { get; set; }

    public string? Action { get; set; }

    public DateTime? ActionDate { get; set; }
}
