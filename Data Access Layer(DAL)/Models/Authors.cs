using MVCProjectLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace MVCProjectExerciseKBase.Models;
//Author can have many books

public class Authors : BaseModel
{
    //public Authors()
    //{
    //    this.Books = new HashSet<Books>();
    //}
    [Key]
    public Guid AuthorId { get; set; }
    public string Name { get; set; }
    public DateTime BirthYear { get; set; }

    public virtual ICollection<BookAuthor> BookAuthors { get; set; }
}
