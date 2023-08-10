namespace EjemploListas;
public class Curso
{
    public List<Alumno> alumnos { get; set; }

    public int curso { get; set; }
    public int division { get; set; }

    public Curso(int curso, int division)
    {
        this.alumnos = new List<Alumno>();
        this.curso = curso;
        this.division = division;
    }

    public void Asignar(Alumno unAlumno)
    {
        this.alumnos.Add(unAlumno);
    }
}