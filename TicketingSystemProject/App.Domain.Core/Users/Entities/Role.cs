namespace App.Domain.Core.Users.Entities;

public class Role
{
    public int Id { get; set; }
    public string Title { get; set; }
    public virtual ICollection<User> Users { get; set; }
}
