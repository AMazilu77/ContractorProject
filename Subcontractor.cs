namespace ContractorProject
{
    // Subcontractor inherits from Contractor.
    // Adds shift, hourly rate, and pay calculation.
    public class Subcontractor : Contractor
    {

        // 1 = Day shift, 2 = Night shift
        public int Shift { get; set; }

        // Hourly pay rate for subcontractor
        public float HourlyPayRate { get; set; }

        // Constructor that passes shared values base Contractor class
        public Subcontractor(string contractorName,
                                 int contractorNumber,
                                 DateTime contractStartDate,
                                 int shift,
                                 float hourlyPayRate)
            : base(contractorName, contractorNumber, contractStartDate)
        {
            Shift = shift;
            HourlyPayRate = hourlyPayRate;
        }


        // Total pay based on hours worked
        // Night shift receives a 3% differentialint contractorNumber
        public float ComputePay(float hoursWorked)
        {
            float pay = HourlyPayRate * hoursWorked;

            // 3% increase for night shift
            if (Shift == 2)
            {
                pay *= 1.03f;
            }

            return pay;
        }

        // Returns readable shift name
        public string GetShiftName()
        {
            return Shift == 1 ? "Day" : "Night";
        }

        // Formats subcontractor information.
        public override string ToString()
        {
            return
                $"Name: {ContractorName}\n" +
                $"Number: {ContractorNumber}\n" +
                $"Start Date: {ContractStartDate.ToShortDateString()}\n" +
                $"Shift: {GetShiftName()}\n" +
                $"Hourly Pay Rate: ${HourlyPayRate:F2}";
        }
    }
}