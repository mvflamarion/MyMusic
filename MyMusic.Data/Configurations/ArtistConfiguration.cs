using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyMusic.Core.Models;

namespace MyMusic.Data.Configurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder
                .HasKey(a => a.Id);
            
            builder
                .Property(a => a.Id)
                .UseIdentityColumn();
            
            builder
                .Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(50);
            
            builder
                .ToTable("Artists");
        }
    }
}