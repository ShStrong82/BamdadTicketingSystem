using App.Domain.Core.Tickets.Entities;
using App.Domain.Core.Users.Enums;

namespace App.Domain.Core.Users.Entities;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Birthdate { get; set; }
    public int RoleId { get; set; }
    public Role Role { get; set; }
    public virtual ICollection<Ticket>? Tickets { get; set; }
    public virtual ICollection<TicketHistory>? TicketsHistories { get; set; }
}
