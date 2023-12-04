namespace transactionservice.Data;
public class Transction {
    public long Id { get; set; }
    public string ClientName {get; set;}
    public double Amount { get; set; }
    public DateTime TransDate { get; set; }
    public string CreatedBy { get; set; }
    

}