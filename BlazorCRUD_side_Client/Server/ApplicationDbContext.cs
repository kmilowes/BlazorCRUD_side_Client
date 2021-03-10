using BlazorCRUD_side_Client.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD_side_Client.Server
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //PAÍSES
            var countries = new List<Country>()
            {
                new Country()
                {
                    Id = 1,
                    NameCountry = "Rep Dom"
                },
                new Country()
                {
                    Id = 2,
                    NameCountry = "Mexico"
                },
                new Country()
                {
                    Id = 3,
                    NameCountry = "Colombia"
                }
            };
            builder.Entity<Country>().HasData(countries);//Agregarlos a la BD de la tabla Country
            //ESTADOS
            var states = new List<State>() { 
                new State() { Id = 1, NameState = "Santo Domingo", IdCountry = 1},
                new State() { Id = 2, NameState = "San Cristobal", IdCountry = 1},
                new State() { Id = 3, NameState = "Ciudad de Mexico", IdCountry = 2},
                new State() { Id = 4, NameState = "Jalisco", IdCountry = 2},
                new State() { Id = 5, NameState = "Bogota", IdCountry = 3},
                new State() { Id = 6, NameState = "Medellin", IdCountry = 3},
                new State() { Id = 7, NameState = "Cartagena", IdCountry = 3}
            };
            builder.Entity<State>().HasData(states);//Agregarlos a la BD de la tabla State



            //Para agregar personas en una tabla
            var person = new List<Person>();
            for(int i=1; i<15; i++)
            {
                person.Add(new Person() { Id = i, Name = $"Persona {i}", StateId = 1 });
            }
            builder.Entity<Person>().HasData(person);//Agregarlos a la BD de la tabla Person
            base.OnModelCreating(builder);
        }

        //Se creará una tabla en la BD basado en el modelo Persona
        public DbSet<Person> People { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }

    }
}
