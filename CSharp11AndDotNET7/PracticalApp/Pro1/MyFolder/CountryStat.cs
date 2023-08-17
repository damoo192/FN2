using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Pro1.MyFolder;

[PrimaryKey("CountryId", "Year")]
public partial class CountryStat
{
    [Key]
    [Column("countryID")]
    public Guid CountryId { get; set; }

    [Key]
    [Column("year")]
    [StringLength(4)]
    [Unicode(false)]
    public string Year { get; set; } = null!;

    [Column("population")]
    public int? Population { get; set; }

    [Column("gdp", TypeName = "decimal(12, 2)")]
    public decimal? Gdp { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("CountryStats")]
    public virtual Country Country { get; set; } = null!;
}
