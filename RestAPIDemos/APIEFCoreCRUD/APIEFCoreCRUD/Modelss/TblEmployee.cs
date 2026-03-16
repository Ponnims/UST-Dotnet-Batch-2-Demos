using System;
using System.Collections.Generic;

namespace APIEFCoreCRUD.Modelss;

public partial class TblEmployee
{
    public int Empid { get; set; }

    public string? Name { get; set; }

    public int? Salary { get; set; }

    public int? Managerid { get; set; }

    public virtual ICollection<TblEmployee> InverseManager { get; set; } = new List<TblEmployee>();

    public virtual TblEmployee? Manager { get; set; }
}
