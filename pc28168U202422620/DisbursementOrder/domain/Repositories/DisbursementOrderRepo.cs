namespace pc28168U202422620.DisbursementOrder.domain.Repositories;
using pc28168U202422620.DisbursementOrder.domain.Aggregates;
public interface DisbursementOrderRepo
{
    Task<bool> ExistsByOrderTrackingCodeAsync(Guid orderTrackingCode, CancellationToken cancellationToken);

    Task AddAsync(DisbursementOrder disbursementOrder, CancellationToken cancellationToken);
    
}