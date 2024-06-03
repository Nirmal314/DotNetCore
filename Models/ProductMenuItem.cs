using System;
using System.Collections.Generic;

namespace Core2.Models;

public partial class ProductMenuItem
{
    public int Id { get; set; }

    public string Itemname { get; set; } = null!;

    public string Itemdesc { get; set; } = null!;

    public int? ProductMenuId { get; set; }

    public virtual ProductMenu? ProductMenu { get; set; }
}
