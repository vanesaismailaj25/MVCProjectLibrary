using MVCProjectLibrary.Models;

namespace MVCProjectExerciseKBase.Models;
//Client can borrow many boks
public class Clients : BaseModel
{
  
    public Guid Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<BookRental> BookRentals { get; set; }

}
