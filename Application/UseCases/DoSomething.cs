using Domain.Interfaces;

namespace Application.UseCases;

public class DoSomething:IDoSmth
{
    public string HelloWorld()
    {
        return "Hello artem";
    }
}