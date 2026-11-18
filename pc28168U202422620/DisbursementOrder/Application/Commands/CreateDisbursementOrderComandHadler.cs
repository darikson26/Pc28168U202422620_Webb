namespace pc28168U202422620.DisbursementOrder.Application.Commands;
using pc28168U202422620.DisbursementOrder.domain.Aggregates;
using pc28168U202422620.DisbursementOrder.domain.Exeptions;
using pc28168U202422620.DisbursementOrder.domain.Repositories;
using  pc28168U202422620.DisbursementOrder.domain.ValueObject;
using  pc28168U202422620.Shared.Domain.ValidObjects;
public sealed record  CreateDisbursementOrderComandHadler(DisbursementOrderRepo repository)
{
    public async Task<DisbursementOrder> HandleAsync(
        CreateDisbursementOrderComand command,
        CancellationToken cancellationToken)
    {
        var order = DisbursementOrder.Create(
            new OpenpayReference(command.OrderTrackingCode),
            new StoreIdentifier(command.AffiliateStoreId),
            new DateInterval(command.ScheduledFrom, command.ScheduledTo),
            new FinancialAmount(command.TransferCapAmount, command.TransferCapCurrencyCode),
            command.User,
            command.Remarks,
            command.Status ?? DisbursementStatus.Queued);

        if (await repository.ExistsByOrderTrackingCodeAsync(command.OrderTrackingCode, cancellationToken))
        {
            throw new DuplicateOrderTrackingCodeException();
        }

        await repository.AddAsync(order, cancellationToken);
        return order;
    }
}