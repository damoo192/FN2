using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packt.Shared;

[Keyless]
public partial class EmployeeTerritory
{
    [Column(TypeName = "INT")]
    public int EmployeeId { get; set; }


    [Required]
    [Column(TypeName = "nvarchar (20)")]
    [StringLength(20)]
    public string TerritoryId { get; set; } = null!;
}
