using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();

//studentRepository.Export();

exportHelper.ExportStudents(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");