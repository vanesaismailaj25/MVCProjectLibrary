using Microsoft.EntityFrameworkCore;
using MVCProjectExerciseKBase.Models;

namespace MVCProjectLibrary.Models;

public class LibraryDBContext: DbContext
{
    public LibraryDBContext(DbContextOptions<LibraryDBContext> options): base(options)
    {

    }

    public DbSet<Authors> Authors { get; set; }
    public DbSet<Books> Books { get; set; }
    public DbSet<Clients> Clients { get; set; }
    public DbSet<BookAuthor> BookAuthors { get; set; }

}
