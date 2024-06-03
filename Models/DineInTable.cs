﻿using System;
using System.Collections.Generic;

namespace Core2.Models;

public partial class DineInTable
{
    public int TableId { get; set; }

    public int? NoOfchairs { get; set; }

    public bool? CanBeReserved { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public int? IsDeleted { get; set; }

    public virtual ICollection<ReservedTable> ReservedTables { get; set; } = new List<ReservedTable>();
}
