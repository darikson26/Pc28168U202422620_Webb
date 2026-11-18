namespace pc28168U202422620.DisbursementOrder.domain.Aggregates;
using pc28168U202422620.Shared.Domain.ValidObjects;
using pc28168U202422620.DisbursementOrder.domain.ValueObject;
public class Disbursement
{
    private Disbursement()
    {
        OrderTrackingCode = null!;
        AffiliateStoreId = null!;
        ExecutionSchedule = null!;
        TransferCap = null!;
    }
    public int Id { get; private set; }
    public OpenpayReference OrderTrackingCode { get; private set; }
    public StoreIdentifier AffiliateStoreId{ get; private set; }
    public DateInterval ExecutionSchedule { get; private set; }
    public FinancialAmount TransferCap{ get; private set; }
    public PrescriptionStatus  Status { get; private set; }
    public string? ClinicalNotes{get;private set;}
    public DateTime CreateReceta{get;private set;}
    public DateTime UpdateReceta{get;private set;}

    public Prescription(RoIdentifier prescriptionNumber, PartyId patientId,
        TreatmentDuration treatmentPeriod, MedicationDosage dosageLimit,
        PrescriptionStatus status = PrescriptionStatus.Draft,
        string? clinicalNotes = null)
    {
        PrescriptionNumber =  prescriptionNumber;
        PatientId = patientId;
        TreatmentPeriod = treatmentPeriod;
        ClinicalNotes = clinicalNotes;
        Status = status;
        DosageLimit = dosageLimit;
        
        CreateReceta = DateTime.UtcNow;
        UpdateReceta = DateTime.UtcNow;
}