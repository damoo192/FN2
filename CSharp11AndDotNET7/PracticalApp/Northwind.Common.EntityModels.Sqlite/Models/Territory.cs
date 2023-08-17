﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packt.Shared;

[Keyless]
public partial class Territory
{
    [Required]
    [Column(TypeName = "nvarchar (20)")]
    [StringLength(20)]
    public string TerritoryId { get; set; } = null!;


    [Required]
    [Column(TypeName = "nchar (50)")]
    [StringLength(50)]
    public string TerritoryDescription { get; set; } = null!;

    [Column(TypeName = "INT")]
    public int RegionId { get; set; }
}
