using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace newwebapi.Controllers
{
    [Route("newwebapi/[controller]")]
    [ApiController]
    public class PreviousEmployeesController: ControllerBase
    {
        // context storing database table information
        private DataContextPreviousEmployees context = null;
        
        // constructor setting the context
        public PreviousEmployeesController(DataContextPreviousEmployees context)
        {
            this.context = context;
        }

        // http request downloading table content
        [HttpGet]
        public async Task<ActionResult<List<PreviousEmployee>>> Get()
        {
            return Ok(await this.context.PreviousEmployees.ToListAsync());
        }

        // http request downloading single item from the table
        [HttpGet("{id}")]
        public async Task<ActionResult<PreviousEmployee>> Get(int id)
        {
            var previousEmployee = await this.context.PreviousEmployees.FindAsync(id);
            if(previousEmployee == null) 
                return BadRequest("Previous employee not found");
            return Ok(previousEmployee);
        }

        // http request posting object to the table
        [HttpPost]
        public async Task<ActionResult<List<PreviousEmployee>>> AddPreviousEmployee(PreviousEmployee previousEmployee)
        {
            this.context.PreviousEmployees.Add(previousEmployee);
            await this.context.SaveChangesAsync();

            return Ok(await this.context.PreviousEmployees.ToListAsync());
        }

        // http request replacing object of the table
        [HttpPut]
        public async Task<ActionResult<List<PreviousEmployee>>> UpdatePreviousEmployee(PreviousEmployee request){
            var dbPreviousEmployee = await this.context.PreviousEmployees.FindAsync(request.Id);
            if(dbPreviousEmployee == null) 
                return BadRequest("Previous employee not found");

            dbPreviousEmployee.FirstName = request.FirstName;
            dbPreviousEmployee.LastName = request.LastName;
            dbPreviousEmployee.Adress = request.Adress;
            dbPreviousEmployee.DateBirth = request.DateBirth;
            dbPreviousEmployee.DateEntry = request.DateEntry;
            dbPreviousEmployee.Position = request.Position;
            dbPreviousEmployee.Flat = request.Flat;

            await this.context.SaveChangesAsync();

            return Ok(await this.context.PreviousEmployees.ToListAsync());
        }

        // http request deleting object of the table
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<PreviousEmployee>>> Delete(int id){
            var dbPreviousEmployee = await this.context.PreviousEmployees.FindAsync(id);

            if(dbPreviousEmployee == null)
                return BadRequest("Previous employee not found");

            this.context.PreviousEmployees.Remove(dbPreviousEmployee);
            await this.context.SaveChangesAsync();

            return Ok(await this.context.PreviousEmployees.ToListAsync());
        }
    }
}