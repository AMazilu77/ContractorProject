using ContractorProject;
using System.Runtime.InteropServices;

// List to store all subcontractors entered by the user
List<Subcontractor> subcontractors = new List<Subcontractor>();

Console.WriteLine("Contractor / Subcontractor payment system");

bool keepGoing = true;

while (keepGoing)
{
    // Collect subcontractor information from user
    Console.WriteLine("\nEnter subcontractor name: ");
    string name = Console.ReadLine() ?? "Unknown";

    Console.WriteLine("Enter subcontractor number: ");
    int number = int.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Enter contractor start date (MM/DD/YYYY): ");
    DateTime startDate = DateTime.Parse(Console.ReadLine() ?? DateTime.Today.ToString("MM/dd/yyyy"));

    Console.WriteLine("Enter shift (1 for day, 2 for night): ");
    int shift = int.Parse(Console.ReadLine() ?? "1");

    // Validate shift input
    while (shift != 1 && shift != 2)
    {
        Console.WriteLine("Invalid shift. Please enter 1 for day or 2 for night: ");
        shift = int.Parse(Console.ReadLine() ?? "1");
    }

    Console.WriteLine("Enter hourly pay rate: ");
    float PayRate = float.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Enter hours worked: ");
    float hoursWorked = float.Parse(Console.ReadLine() ?? "0");

    // Create subcontractor object using collected data
    Subcontractor subcontractor = new Subcontractor(
        name,
        number,
        startDate,
        shift,
        PayRate
        );

    // Add to list for summary at end
    subcontractors.Add(subcontractor);

    // Compute total pay
    float totalPay = subcontractor.ComputePay(hoursWorked);

    // Display formatted subcontractor information
    Console.WriteLine("\nSubcontractor Created:");
    Console.WriteLine($"Name: {subcontractor.ContractorName}");
    Console.WriteLine($"Number: {subcontractor.ContractorNumber}");
    Console.WriteLine($"Start Date: {subcontractor.ContractStartDate.ToShortDateString()}");
    Console.WriteLine($"Shift: {subcontractor.GetShiftName()}");
    Console.WriteLine($"Hourly Pay Rate: ${subcontractor.HourlyPayRate:F2}");
    Console.WriteLine($"Hours Worked: {hoursWorked}");
    Console.WriteLine($"Total Pay: ${totalPay:F2}");

    // Ask user if they want to continue
    Console.WriteLine("\nWould you like to enter another subcontractor? (Type 'exit' to quit)");
    string answer = Console.ReadLine() ?? "";

    if (answer.Trim().ToLower() == "exit")
    {
        keepGoing = false;
   }
}

// Display all subcontractors entered during session
Console.WriteLine("\nAll subcontractors entered: ");
Console.WriteLine("-----------------------------");

foreach (Subcontractor subcontractor in subcontractors)
{
    Console.WriteLine($"{subcontractor.ContractorName} - #{subcontractor.ContractorNumber} - {subcontractor.GetShiftName()} - ${subcontractor.HourlyPayRate:F2}/hr");
}
