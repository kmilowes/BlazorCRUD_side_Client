using BlazorCRUD_side_Client.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD_side_Client.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        //Lo primero será inyectar el DbContext
        public PeopleController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        [HttpGet]
        //Traer todas las personas
        public async Task<ActionResult<List<Person>>> Get()
        {
            return await context.People.ToListAsync();
        }

        [HttpGet("{id}", Name = "ObtenerPersona")]
        public async Task<ActionResult<Person>> Get(int id)
        {
            //return await context.People.FirstOrDefaultAsync(x => x.Id == id);
            //Para incluir la información del estado, se se quiere editar
            return await context.People.Include(x => x.State).FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Person person)
        {
            context.Add(person);
            await context.SaveChangesAsync();
            //Crear el resultado a partir de una ruta(Para mejores practicas cuando se crea un registro)
            return new CreatedAtRouteResult("ObtenerPersona", new { id = person.Id }, person);
        }
        
        [HttpPut]
        public async Task<ActionResult> Put(Person person)
        {
            context.Entry(person).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var person = new Person { Id = Id };
            context.Remove(person);
            await context.SaveChangesAsync();
            return NoContent();
        }

    }
}
