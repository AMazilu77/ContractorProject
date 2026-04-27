namespace ContractorProject
{
    // Base class representing contractor.
    // Stores shared information all subcontractors inherit.
    public class Contractor
    {

        // Contractor's name
        public string ContractorName { get; set; }

        // Unique contractor ID number
        public int ContractorNumber { get; set; }

        // Date the contractor started
        public DateTime ContractStartDate { get; set; }

        // Main constructor used by Subcontractor class.
        // Initializes contractor information.
        public Contractor(string contractorName, int contractorNumber, DateTime contractStartDate)
        {
            ContractorName = contractorName;
            ContractorNumber = contractorNumber;
            ContractStartDate = contractStartDate;
        }
    }
}