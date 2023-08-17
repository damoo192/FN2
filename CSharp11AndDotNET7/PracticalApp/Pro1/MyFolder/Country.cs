using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Pro1.MyFolder;

public partial class Country
{
    [Key]
    [Column("countryID")]
    public Guid CountryId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("area", TypeName = "decimal(12, 2)")]
    public decimal? Area { get; set; }

    [Column("nationalDay", TypeName = "date")]
    public DateTime? NationalDay { get; set; }

    [Column("countryCode2")]
    [StringLength(2)]
    [Unicode(false)]
    public string? CountryCode2 { get; set; }

    [Column("countryCode3")]
    [StringLength(3)]
    [Unicode(false)]
    public string? CountryCode3 { get; set; }

    [Column("regionID")]
    public Guid? RegionId { get; set; }

    [InverseProperty("Country")]
    public virtual ICollection<CountryLanguage> CountryLanguages { get; set; } = new List<CountryLanguage>();

    [InverseProperty("Country")]
    public virtual ICollection<CountryStat> CountryStats { get; set; } = new List<CountryStat>();

    [ForeignKey("RegionId")]
    [InverseProperty("Countries")]
    public virtual Region? Region { get; set; }
}
