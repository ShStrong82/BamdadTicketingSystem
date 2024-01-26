namespace App.Domain.Core.Tickets.Entities;

public class Constants
{
    public int Id { get; set; }
    public string Title { get; set; }
    public virtual ICollection<Ticket> TicketByCategory { get; set; }
    public virtual ICollection<Ticket> TicketByPriority { get; set; }
    public virtual ICollection<TicketHistory> TicketByStatus { get; set; }
    
}
