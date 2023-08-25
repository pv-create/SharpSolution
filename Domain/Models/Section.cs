using Domain.Shared;

namespace Domain.Models;
/// <summary>
/// Модель описывающая раздел приложения (например раздел о здоровье самообразовании и тд)
/// </summary>
public class Section:BaseModel
{
    public string Name { get; set; }
}