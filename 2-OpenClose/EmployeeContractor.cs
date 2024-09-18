namespace OpenClose
{
  //El valor de la hora del EmployeeContractor no esta definido en el requerimiento
  //Pero dejamos lista la clase solo de implementar extendiendo el codigo pero no cambiandolo
    public class EmployeeContractor : Employee
    {

        public EmployeeContractor(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }  

        public override decimal CalculateSalaryMonthly() {
            throw new NotImplementedException();
        }
    }
}