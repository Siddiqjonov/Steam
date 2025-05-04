namespace GameStore.DataAccess.Entities;

public class GamePlatform
{
    public required Guid GameId { get; set; }
    public Game Game { get; set; }

    public required Guid PlatformId { get; set; }
    public Platform Platform { get; set; }
}
