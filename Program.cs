using EjemploListas;
using System.Text.Json;

var curso = new Curso(5, 7);

curso.Asignar(new Alumno() { nombre = "Pepe", DNI = 1111111, edad = 18 });
curso.Asignar(new Alumno() { nombre = "Roque", DNI = 12222, edad = 15 });
curso.Asignar(new Alumno() { nombre = "Josbert", DNI = 3311, edad = 15 });
curso.Asignar(new Alumno() { nombre = "David", DNI = 44442, edad = 20 });
curso.Asignar(new Alumno() { nombre = "Pepe", DNI = 13424321, edad = 21 });

var alumnoMenorEdad1 = curso.alumnos.OrderBy(x => x.edad).First();
Console.WriteLine(JsonSerializer.Serialize(alumnoMenorEdad1));

var edadMasChica = curso.alumnos.Min(x => x.edad);
var alumnosMenoresEdad = curso.alumnos.Where(x => x.edad == edadMasChica);
Console.WriteLine(JsonSerializer.Serialize(alumnosMenoresEdad));

var edadMasGrande = curso.alumnos.Max(x => x.edad);
var alumnosMayoresEdad = curso.alumnos.Where(x => x.edad == edadMasGrande);
Console.WriteLine(JsonSerializer.Serialize(alumnosMayoresEdad));

var alumnosConEdadPar = curso.alumnos.Where(alumno => alumno.edad % 2 == 0);
Console.WriteLine(JsonSerializer.Serialize(alumnosConEdadPar));

//Notacion fluent
var alumno = curso.alumnos.Where(alumno => alumno.edad % 2 == 0);
Console.WriteLine(JsonSerializer.Serialize(alumno));

//Notacion Query
var alumno2 = from a in curso.alumnos
              where a.edad % 2 == 0
              select a;

Console.WriteLine(JsonSerializer.Serialize(alumno2));



var alumnoConSelect = curso.alumnos
    .Select(x => new
    {
        Mote = x.nombre,
        Edad = x.edad,
        EsMayorEdad = x.edad >= 18 ? true : false
    });

Console.WriteLine(JsonSerializer.Serialize(alumnoConSelect));