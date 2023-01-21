using MVCProjectLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace MVCProjectExerciseKBase.Models;
//Book can have many authors

public class Books : BaseModel
{
    //public Books()
    //{
    //    this.Authors=new HashSet<Authors>();
    //}
    [Key]
    public Guid BookId { get; set; }
    public string Title { get; set; }
    public double Price { get; set; }
    public DateTime PublishedYear { get; set; }
    public virtual ICollection<BookAuthor> BookAuthors { get; set; }
}
