using Domain.Shared;

namespace Domain.Models;

public class Post:BaseModel
{
    public string Name { get; set; }
    public string Content { get; set; }
}