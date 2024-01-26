using App.Domain.Core.Tickets.Entities;
using App.Domain.Core.Users.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Db.SqlServer.Ef.EntitiesConfigs.Tickets;

public class TicketHistoryEntityConfig : IEntityTypeConfiguration<TicketHistory>
{
    public void Configure(EntityTypeBuilder<TicketHistory> builder)
    {
        builder.ToTable("TicketHistories");
        builder.HasKey(t => t.Id);
        builder.Property(t => t.TicketId).IsRequired();
        builder.Property(t => t.ChangeAt).HasColumnType("datetime");
        builder.HasOne(t => t.ChangeBy).WithMany(m => m.TicketsHistories).HasForeignKey(t => t.ChangeByUserId);
        builder.HasOne(t => t.Ticket).WithMany(t => t.TicketHistories).HasForeignKey(t => t.TicketId);
        builder.HasOne(t => t.Status).WithMany(s => s.TicketByStatus).HasForeignKey(t => t.StatusId);
    }
}
