using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Pro1.MyFolder;

public partial class Language
{
    [Key]
    [Column("languageID")]
    public Guid LanguageId { get; set; }

    [Column("language")]
    [StringLength(50)]
    public string? Language1 { get; set; }

    [InverseProperty("Language")]
    public virtual ICollection<CountryLanguage> CountryLanguages { get; set; } = new List<CountryLanguage>();
}
