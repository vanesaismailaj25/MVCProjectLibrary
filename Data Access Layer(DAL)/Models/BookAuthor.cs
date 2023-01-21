using MVCProjectExerciseKBase.Models;

namespace MVCProjectLibrary.Models;

public class BookAuthor : BaseModel
{
    public Guid Id { get; set; }
    public Guid AuthorId { get; set; }
    public Authors Author { get; set; }
    public Guid BookId { get; set; }
    public Books Book { get; set; }
}
