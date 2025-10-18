namespace Models;
public class TransactionResultsResponse : OkResponse<TransactionDetail[]>
{
}

public class TransactionDetail
{
    public string? TransactionId { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string? Status { get; set; }
}