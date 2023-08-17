using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Packt.Shared;

public partial class Employee
{
    [Key]
    [Column("EmployeeID")]
    public int EmployeeId { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Photo { get; set; }

    [StringLength(1024)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [InverseProperty("Employee")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
