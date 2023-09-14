namespace Db.Interfaces;

public interface IComplimentsRepository
{
    public IEnumerable<string> GetAllCompliments();
    public string GetComplimentById(int count);
}