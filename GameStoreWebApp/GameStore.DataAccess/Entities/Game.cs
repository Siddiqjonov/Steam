﻿namespace GameStore.DataAccess.Entities;

public class Game
{
    public required Guid GameId { get; set; }
    public required string Name { get; set; }
    public required string Key { get; set; }
    public string? Description { get; set; }

    public ICollection<GameGenre> GameGenres { get; set; }
    public ICollection<GamePlatform> GamePlatforms { get; set; }
}
