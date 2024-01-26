using App.Domain.Core.Users.Entities;

namespace App.Domain.Core.Tickets.Entities;

public class TicketHistory
{
    public int Id { get; set; }
    public int TicketId { get; set; }
    public Ticket Ticket { get; set; }
    public int StatusId { get; set; }
    public Constants Status { get; set; }
    public DateTime ChangeAt { get; set; }
    public int ChangeByUserId { get; set; }
    public User ChangeBy { get; set; }
}
