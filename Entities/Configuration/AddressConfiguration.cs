using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
       
            public void Configure(EntityTypeBuilder<Address> builder)
            {
                builder.HasData(
                    new Address
                    {
                        AddressId = 1, City = "London", Street = "Frying Pan Road", Country = "UK", StudentId = 1
                    },
                    new Address { AddressId = 2, City = "Cincinnati", Street = "Error Place", Country = "USA", StudentId = 2},
                    new Address { AddressId = 3, City = "Rome", Street = "Bad Route Road", Country = "Italy", StudentId = 3},
                    new Address { AddressId = 4, City = "Las Vegas", Street = "Pillow Talk Court", Country = "USA", StudentId = 4},
                    new Address { AddressId = 5, City = "Berlin", Street = "This Street", Country = "Germany", StudentId = 5}
                );
            }
        
    }
}