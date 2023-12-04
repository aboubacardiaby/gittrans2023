using System.Transactions;
using Microsoft.EntityFrameworkCore;
namespace transactionservice.Data;
public class TransactionDataContext : DbContext
{
public TransactionDataContext(DbContextOptions<TransactionDataContext> options)
            : base(options)
    {
        

    }
 public DbSet<Transction> tblTransaction { get; set; }
}