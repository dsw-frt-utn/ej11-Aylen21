using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary

{
    private Dictionary<int, Alumno> alumnos;
    
    
    public CasoDictionary()
    {
        alumnos = new Dictionary<int, Alumno>();

    }
    public void AgregarAlumno(int legajo,Alumno alumno) {

        if (alumno == null) {
            Console.WriteLine("El alumno es null");
            return;
        }

        alumnos[legajo] = alumno;

    }

    public Alumno BuscarAlumno(int legajo) {

        if (alumnos.ContainsKey(legajo)){

            return alumnos[legajo];
        
        }

        return null;
    
    
    }


    public Dictionary<int, Alumno> RetonarDiccionario() {
        return alumnos;




     }

    public bool EliminarAlumno(int legajo)
    {

        if (BuscarAlumno(legajo) == null){

            return false;

        }
        else {

            alumnos.Remove(legajo);
            return true;
        
        }


    }


}
