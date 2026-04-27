namespace ContractorProject;

public class Subcontractor : Contractor {
    
    public int Shift { get; set; }
    public double HourlyPayRate { get; set; }
    public Subcontractor()
        : base(string.Empty, 0, DateTime.Now)
    {
        Shift = 1;
        HourlyPayRate = 0.0;
    }

    public Subcontractor(string ContractorName,
     int contractorNumber,
     DateTime contractStartDate,
     int shift,
     double hourlyPayRate)
     : base(ContractorName, contractorNumber, contractStartDate) {
        Shift = shift;
        HourlyPayRate = hourlyPayRate;
    }

    public float ComputePay(float hoursWorked)
    {
        double pay = HourlyPayRate * hoursWorked;
        if (Shift == 2) {
            pay *= 1.03; // 3% increase for second shift
        } 
        
        return (float)pay;
    }

    public string GetShiftName() {
        return Shift == 1 ? "Day shift" : "Night";
    }

}