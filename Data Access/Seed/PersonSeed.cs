using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Person.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Seed
{
    public class PersonSeed : IEntityTypeConfiguration<PersonModel>
    {
        public void Configure(EntityTypeBuilder<PersonModel> builder)
        {
            builder.HasData(
                new PersonModel
                {
                    Id=1,
                    Name="Sevval",
                    Surname="Karadeniz",
                    Age=22,
                    Gender="female",
                    Birthday="12/07/2001",
                    City="Istanbul",

                },
                new PersonModel
                {
                    Id = 2,
                    Name = "Simal",
                    Surname = "Karadeniz",
                    Age = 22,
                    Gender="female",
                    Birthday = "12/07/2006",
                    City = "Denizli",
                },
                 new PersonModel
                 {
                     Id = 3,
                     Name = "Name3",
                     Surname = "Surname3",
                     Age = 22,
                     Gender="male",
                     Birthday = "1/11/2001",
                     City = "Istanbul",
                 }
                );
        }
    }
}
