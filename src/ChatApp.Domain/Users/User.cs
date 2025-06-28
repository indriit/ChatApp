public sealed class User
{
    public long Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public DateTime CreatedOn { get; private set; }


    public static User Create(string name, string email, string passwordHash, DateTime createdOn)
    {

    }
}
