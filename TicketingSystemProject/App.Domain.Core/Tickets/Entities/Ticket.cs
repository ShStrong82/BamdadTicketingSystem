using App.Domain.Core.Tickets.Enums;
using App.Domain.Core.Users.Entities;

namespace App.Domain.Core.Tickets.Entities;

public class Ticket
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public Constants Category { get; set; }
    public int CategoryId { get; set; }
    public int PriorityId { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public Constants Priority { get; set; }
    public string Description { get; set; }
    public DateTime SubmitAt { get; set; }
    public int SubmitByUserId { get; set; }
    public virtual ICollection<TicketHistory> TicketHistories { get; set; }
}
