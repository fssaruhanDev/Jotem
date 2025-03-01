using System.Security.Claims;

namespace Jotem.Infrastructure.Security.Settings;

public interface IJwtProvider
{
    string GenerateToken(Claim[] claims, DateTime expiresAt);
}
