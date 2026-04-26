namespace ContractorProject;

public class Contractor {
    public string ContractorName { get; set; }
    public int ContractorNumber { get; set; }
    public DateTime ContractStartDate { get; set; }

    public Contractor(string name, decimal hourlyRate) {
        ContractorName = "Unknown";
        ContractorNumber = 0;
        ContractStartDate = DateTime.Today;
    }

    public Contractor(string contractorName, int contractorNumber, DateTime contractStartDate) {
        ContractorName = contractorName;
        ContractorNumber = contractorNumber;
        ContractStartDate = contractStartDate;
    }
}