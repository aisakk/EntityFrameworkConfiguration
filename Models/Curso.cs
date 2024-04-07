

using System.ComponentModel.DataAnnotations.Schema;

public class Curso{
    public int CursoId{get; set;}
    public string Name_Curso{get; set;}
    public int IDAlumno{get;set;}
    public Alumno Alumnos{get; set;}   
}