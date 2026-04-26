namespace ContractorProject;

class Program {
    static void Main(){

        List<Subcontractor> subcontractors = new List<Subcontractor>();

        Console.WriteLine("Contractor / Subcontractor payment system");

        bool keepGoing = true;

        while (keepGoing) {
            Console.WriteLine("\nEnter subcontractor name: ");
            string name = Console.ReadLine() ?? "Unknown";

            Console.WriteLine("Enter subcontractor number: ");
            int number = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Enter contractor start date (MM/DD/YYYY): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine() ?? DateTime.Today.ToString("MM/dd/yyyy"));

            Console.WriteLine("Enter shift (1 for day, 2 for night): ");
            int shift = int.Parse(Console.ReadLine() ?? "1");

            while (shift != 1 && shift != 2) {
                Console.WriteLine("Invalid shift. Please enter 1 for day or 2 for night: ");
                shift = int.Parse(Console.ReadLine() ?? "1");
            }

            Console.WriteLine("Enter hourly pay rate: ");
            double PayRate = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Enter hours worked: ");
            float hoursWorked = float.Parse(Console.ReadLine() ?? "0");

            Subcontractor subcontractor = new Subcontractor(
                name,
                number,
                startDate,
                shift,
                PayRate
                );

                subcontractors.Add(subcontractor);

                float totalPay = subcontractor.ComputePay(hoursWorked);

                Console.WriteLine("/nSubcontractor Created: ");
                Console.WriteLine($"Name: {subcontractor.ContractorName}");
                Console.WriteLine($"Number: {subcontractor.ContractorNumber}");
                Console.WriteLine($"Start Date: {subcontractor.ContractStartDate.ToShortDateString()}");
                Console.WriteLine($"Shift: {subcontractor.GetShiftName()}");
                Console.WriteLine($"Hourly Pay Rate: {subcontractor.HourlyPayRate:C}");
                Console.WriteLine($"Hours Worked {hoursWorked} hours: {hoursWorked:C}");
                Console.WriteLine($"Total Pay: ${totalPay:F2}");

                Console.WriteLine("/nWould you like to enter another subcontractor? (Type 'exit' to quit)");
                string answer = Console.ReadLine() ?? "n";

            // if (answer == 'y')    
            // {

            //     keepGoing = false;
            // }

        //     if (name.ToLower() == "exit") {
        //         keepGoing = false;
        //         continue;
        
        // }
     }

     Console.WriteLine("\nAll subcontractors entered: ");
     Console.WriteLine("-----------------------------");

     foreach (Subcontractor subcontractor in subcontractors) {
            Console.WriteLine($"{subcontractor.ContractorName} - #{subcontractor.ContractorNumber} - {subcontractor.GetShiftName()} - ${subcontractor.HourlyPayRate:F2}/hr");     }
 }
}
 