using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.Entities;

namespace VissSoft.Infrastracture.Configurations
{
    public class NewAndEventConfiguration : IEntityTypeConfiguration<NewAndEvent>
    {
        public void Configure(EntityTypeBuilder<NewAndEvent> builder)
        {
            builder.ToTable("newAndEvent");
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).ValueGeneratedOnAdd();
        }
    }
}
