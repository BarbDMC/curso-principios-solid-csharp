namespace Liskov
{
    public class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullname, int hoursWorked) : base(fullname, hoursWorked)
        {
        }

        public override decimal CalculateSalary ()
        {   
            decimal HOURVALUE = 40;
            return HOURVALUE * HoursWorked;
        } 
    }
}