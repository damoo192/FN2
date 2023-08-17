using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Pro1.MyFolder;

public partial class Region
{
    [Key]
    [Column("regionID")]
    public Guid RegionId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("continentID")]
    public Guid? ContinentId { get; set; }

    [ForeignKey("ContinentId")]
    [InverseProperty("Regions")]
    public virtual Continent? Continent { get; set; }

    [InverseProperty("Region")]
    public virtual ICollection<Country> Countries { get; set; } = new List<Country>();
}
