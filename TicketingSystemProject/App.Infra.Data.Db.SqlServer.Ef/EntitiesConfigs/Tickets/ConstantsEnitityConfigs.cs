using App.Domain.Core.Tickets.Entities;
using App.Domain.Core.Users.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Db.SqlServer.Ef.EntitiesConfigs.Tickets;

public class ConstantsEnitityConfigs : IEntityTypeConfiguration<Constants>
{
    public void Configure(EntityTypeBuilder<Constants> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(c => c.Title).HasMaxLength(50);
    }
}
