using Microsoft.EntityFrameworkCore;

namespace Data.Models.Dto
{
    [Owned]
    public sealed record MetadataDto
    {
        public static DateTime CreatedAt => DateTime.UtcNow;
        public static DateTime ModifiedAt => DateTime.UtcNow;
        public string CreatedBy { get; set; } = null!;
        public string ModifiedBy { get; set; } = null!;
    }
}
