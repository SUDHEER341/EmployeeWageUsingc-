namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage objemployee = new EmployeeWage();
            objemployee.CheckAttendance();
            objemployee.Daily_Wage();
            objemployee.PartTimeEmployee();
            objemployee.EmployeeUsingSwitchCase();
           
        }
    }
}