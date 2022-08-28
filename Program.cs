namespace EmployeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employe Wage");
            Console.WriteLine("Choose option \n 1. Check abs or pres \n 2. Calculate daily wage \n 3. Add Part time wage \n 4. Calculate daily wage using case \n 5. Calculate Emp wagr for month \n 6.Calculate emp wage for 100hour or 20 days");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1 :
                    EmpPresOrAbs.UC1();
                    break;
                case 2 :
                    DailyWage.CalculateDailyWage();
                    break;
                case 3:
                    AddPartTimeWage.CalculateDailyPartTimeWage();
                    break;
                case 4:
                    DailyWageUsingCase.CalculateDailyWageUsingCase();
                    break;
                case 5:
                    CalculateWageForMonth.MonthWage();
                    break;
                case 6:
                    CalculateWageForMaxHour.CalculateWage();
                    break;
                    Bullaswami
            }
        }
    }
}