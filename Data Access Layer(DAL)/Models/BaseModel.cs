using System;

namespace MVCProjectExerciseKBase.Models;
public class BaseModel
{
    public DateTime DateCreated { get; set; } = DateTime.Now;

    public DateTime Dateupdated { get; set; } = DateTime.Now;

    public bool IsDeleted { get; set; } = false;

}