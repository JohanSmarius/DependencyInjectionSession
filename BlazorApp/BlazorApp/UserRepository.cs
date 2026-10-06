using DIExplanation;

namespace BlazorApp;

public class UserRepository : IUserRepository
{
    public User GetUser(int id)
    {
        return new User { NumberOfTimesOrdered = 2 };
    }
}
