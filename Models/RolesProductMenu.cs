using System;
using System.Collections.Generic;

namespace Core2.Models;

public partial class RolesProductMenu
{
    public int Id { get; set; }

    public int? RoleId { get; set; }

    public int? ProductMenuId { get; set; }

    public virtual ProductMenu? ProductMenu { get; set; }

    public virtual Role? Role { get; set; }
}
