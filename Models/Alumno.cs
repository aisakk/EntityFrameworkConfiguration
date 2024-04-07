
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Alumno{
    public int Id{get; set;}
    public string firstName{get;set;} 
    public string lastName{get;set;}

    public ICollection<Curso> Cursos {get;} = new List<Curso>();
}