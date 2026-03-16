using System;
using System.Collections.Generic;

namespace APIEFCoreCRUD.Modelss;

public partial class TblProject
{
    public int ProjectId { get; set; }

    public string? Projectname { get; set; }

    public virtual ICollection<TblDeveloper> TblDevelopers { get; set; } = new List<TblDeveloper>();
}
