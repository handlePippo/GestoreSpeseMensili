using Microsoft.EntityFrameworkCore;

namespace Data.Models
{
    [Owned]
    public sealed record MetadataDto
    {
        public DateTime CreatedAt => DateTime.Now;
        public string CreatedBy { get; set; } = null!;
        public DateTime ModifiedAt => DateTime.Now;
        public string ModifiedBy { get; set; } = null!;
    }
}
