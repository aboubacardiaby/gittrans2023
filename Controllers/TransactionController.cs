using System.Transactions;
using Microsoft.AspNetCore.Mvc;
using transactionservice.Data;

namespace transactionservice.Controllers;

[ApiController]
[Route("[controller]")]
public class transactionController : ControllerBase
{
    private readonly IRepository _repository;

    public transactionController(IRepository repository){
        this._repository = repository;
    }
      [HttpGet(Name = "GetTrans")]
    public async  Task<IEnumerable<Transction>> Get()
    {
        var query =  await _repository.GetTransction(); 
        return  query;
    }
}
