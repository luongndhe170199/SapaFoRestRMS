﻿using System;
using System.Collections.Generic;

namespace DomainAccessLayer.Models;

public partial class BrandBanner
{
    public int BannerId { get; set; }

    public string? Title { get; set; }

    public string? ImageUrl { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Status { get; set; }

    public int? CreatedBy { get; set; }

    public virtual User? CreatedByNavigation { get; set; }
}
