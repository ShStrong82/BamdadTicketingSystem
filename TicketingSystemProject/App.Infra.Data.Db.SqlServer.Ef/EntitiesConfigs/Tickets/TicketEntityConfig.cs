using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Tickets.Entities;

namespace App.Infra.Data.Db.SqlServer.Ef.EntitiesConfigs.Tickets;

public class TicketEntityConfig : IEntityTypeConfiguration<Ticket>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Ticket> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.UserId).IsRequired();
        builder.Property(t => t.Subject).HasMaxLength(50);
        builder.Property(t => t.Description).HasMaxLength(512);
        builder.Property(t => t.SubmitAt).HasColumnType("datetime");
        builder.HasOne(t => t.User).WithMany(u => u.Tickets).HasForeignKey(t => t.UserId);
        builder.HasOne(t => t.Category).WithMany(u => u.TicketByCategory).HasForeignKey(t => t.CategoryId);
        builder.HasOne(t => t.Priority).WithMany(u => u.TicketByPriority).HasForeignKey(t => t.PriorityId);
    }
}
