namespace AuthService.Domain.Entities;

public sealed class User
{
    public Guid Id { get; set; }

    public Guid TenantId { get; set; }
    public Tenant Tenant { get; set; } = default!;

    public string Email { get; set; } = default!;
    public string PasswordHash { get; set; } = default!;
    public string SecurityStamp { get; set; } = Guid.NewGuid().ToString("N");

    public bool IsActive { get; set; } = true;
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
