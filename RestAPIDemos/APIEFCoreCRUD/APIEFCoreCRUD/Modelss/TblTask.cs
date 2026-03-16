using System;
using System.Collections.Generic;

namespace APIEFCoreCRUD.Modelss;

public partial class TblTask
{
    public int Taskid { get; set; }

    public string? TaskName { get; set; }

    public int? AssignedTo { get; set; }

    public string? Status { get; set; }

    public DateOnly? DueDate { get; set; }

    public virtual TblDeveloper? AssignedToNavigation { get; set; }
}
