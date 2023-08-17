using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Pro1.MyFolder;

public partial class Continent
{
    [Key]
    [Column("continentID")]
    public Guid ContinentId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [InverseProperty("Continent")]
    public virtual ICollection<Region> Regions { get; set; } = new List<Region>();
}
