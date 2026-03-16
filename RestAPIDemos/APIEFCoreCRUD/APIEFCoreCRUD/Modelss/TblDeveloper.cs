using System;
using System.Collections.Generic;

namespace APIEFCoreCRUD.Modelss;

public partial class TblDeveloper
{
    public int Developerid { get; set; }

    public string? DevName { get; set; }

    public int? ProjectId { get; set; }

    public string? Experience { get; set; }

    public int? Salary { get; set; }

    public virtual TblProject? Project { get; set; }

    public virtual ICollection<TblTask> TblTasks { get; set; } = new List<TblTask>();
}
