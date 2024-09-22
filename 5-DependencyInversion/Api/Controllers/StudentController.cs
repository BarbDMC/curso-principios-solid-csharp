using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    // En vez de instaciar las clases en el controlador, creamos variables con el tipo que necesitamos
    ILogbook logbook;
    IStudentRepository studentRepository;

    // y recibimos por parámetro en el constructor las instancias de las clases, las cuales, luego asignamos a nuestras variables
    public StudentController(IStudentRepository student, ILogbook log) {
        logbook = log;
        studentRepository = student;
    }


    [HttpGet]
    public IEnumerable<Student> Get()
    {
        logbook.Add($"returning student's list");
        return studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody]Student student)
    {
        studentRepository.Add(student);
        logbook.Add($"The Student {student.Fullname} have been added");
    }
}
