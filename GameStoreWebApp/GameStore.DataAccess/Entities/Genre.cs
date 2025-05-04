namespace GameStore.DataAccess.Entities;

public class Genre
{
    public required Guid GenreId { get; set; }
    public required string Name { get; set; }

    public Guid? ParentGenreId { get; set; }
    public Genre? ParentGenre { get; set; }
    public ICollection<Genre>? SubGenres { get; set; }
    public ICollection<GameGenre> GenreGames { get; set; }
}
