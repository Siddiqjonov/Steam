namespace GameStore.DataAccess.Entities;

public class GameGenre
{
    public required Guid GameId { get; set; }
    public Game Game { get; set; }

    public required Guid GenreId { get; set; }
    public Genre Genre { get; set; }
}
