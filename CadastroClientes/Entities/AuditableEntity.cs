using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CadastroDomain.Entities;
public abstract class AuditableEntity
{
    public Guid id { get; set; }
    public DateTime created { get; set; }
    public DateTime? lastModified { get; set; }
    public DateTime? detachmentDate { get; set; }
    public int rowVersion { get; set; }
}
