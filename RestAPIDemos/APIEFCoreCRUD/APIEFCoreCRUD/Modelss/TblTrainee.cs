using System;
using System.Collections.Generic;

namespace APIEFCoreCRUD.Modelss;

public partial class TblTrainee
{
    public int Traineeid { get; set; }

    public string? Name { get; set; }

    public string? Stream { get; set; }

    public int? Score { get; set; }
}
