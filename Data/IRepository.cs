using System.Transactions;

namespace transactionservice.Data;
public interface IRepository{
    Task<List<Transction>> GetTransction();
    Task AddnewTransaction(Transction transaction);
}