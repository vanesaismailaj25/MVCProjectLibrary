using MVCProjectExerciseKBase.Models;

namespace MVCProjectLibrary.Models;

public class BookRental
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Books Book { get; set; }

    public Guid ClientId { get; set; }
    public  Clients Client { get; set; }

}
