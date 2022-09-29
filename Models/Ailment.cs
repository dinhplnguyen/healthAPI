using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAPI.Models
{
  public class Ailment
  {
    [Key]
    public string? Name { get; set; }

    [ForeignKey("PatientId")]
    public Patient? Patient { get; set; }
    public int PatientId { get; set; }

  }
}