using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Pro1.MyFolder;

[PrimaryKey("CountryId", "LanguageId")]
public partial class CountryLanguage
{
    [Key]
    [Column("countryID")]
    public Guid CountryId { get; set; }

    [Key]
    [Column("languageID")]
    public Guid LanguageId { get; set; }

    [Column("official")]
    [StringLength(50)]
    public string? Official { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("CountryLanguages")]
    public virtual Country Country { get; set; } = null!;

    [ForeignKey("LanguageId")]
    [InverseProperty("CountryLanguages")]
    public virtual Language Language { get; set; } = null!;
}
