namespace Liskov
{
    public class EmployeeFullTime : Employee
    {
        public int ExtraHours {get;set;}
        public EmployeeFullTime(string fullname, int hoursWorked, int extrahours) : base(fullname, hoursWorked)
        {
        }

        public override decimal CalculateSalary ()
        {   
            decimal HOURVALUE = 50;
            return HOURVALUE * (HoursWorked + ExtraHours);
        } 
    }
}