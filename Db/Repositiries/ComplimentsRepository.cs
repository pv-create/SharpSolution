using Db.DbSettings;
using Microsoft.EntityFrameworkCore;
using Db.Interfaces;

namespace Db.Repositiries;

public class ComplimentsRepository : IComplimentsRepository
{
    private readonly ApplicationDbContext context;
    
    public ComplimentsRepository(ApplicationDbContext context)
    {
        this.context = context;
    }
    
    public IEnumerable<string> GetAllCompliments()
    {
        return context.Compliments.Select(x => x.ComplimentString );
    }

    public string GetComplimentById(int complimentId)
    {
        return context.Compliments.First(x => x.Id == complimentId).ComplimentString;
    }
}