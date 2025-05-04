namespace GameStore.DataAccess.Entities;

public class Platform
{
    public required Guid PlatformId { get; set; }
    public required string Type { get; set; }

    public ICollection<GamePlatform> PlatformGames { get; set; }
}
