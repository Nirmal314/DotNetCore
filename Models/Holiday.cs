﻿using System;
using System.Collections.Generic;

namespace Core2.Models;

public partial class Holiday
{
    public int HolidayId { get; set; }

    public string? HolidayName { get; set; }

    public string? HolidayMonthDay { get; set; }
}
