
using System.Runtime.InteropServices;
using System.Transactions;
using Microsoft.EntityFrameworkCore;

namespace transactionservice.Data;
public class Repository : IRepository
{
    private readonly TransactionDataContext _context;

    public Repository(TransactionDataContext context){
        this._context = context;
    }

    public async Task AddnewTransaction(Transction transaction)
    {
        try
        {
            _context.tblTransaction.Add(transaction);
            _context.SaveChangesAsync();
        }catch( Exception exc){

        }
        
    }

    public async Task< List<Transction>> GetTransction()
    {
         await _context.Database.EnsureCreatedAsync();
        var query = await _context.tblTransaction.ToListAsync();
        return   query;
    }
}