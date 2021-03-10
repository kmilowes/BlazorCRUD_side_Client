using BlazorCRUD_side_Client.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD_side_Client.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public CountriesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //Listado de Países
        [HttpGet]
        public async Task<ActionResult<List<Country>>> Get() {
            return await context.Country.OrderBy(x => x.NameCountry).ToListAsync();
        }

        //Listado de Estados
        [HttpGet("{paisId}/estados")]
        public async Task<ActionResult<List<State>>> GetEsstados(int paisId) {
            return await context.State.Where(x => x.IdCountry == paisId)
                .OrderBy(x => x.NameState).ToListAsync();
        }

    }
}
