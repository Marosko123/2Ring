using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace newwebapi.Controllers
{
    [Route("newwebapi/[controller]")]
    [ApiController]
    public class EmployeeController: ControllerBase
    {
        // context storing database table information
        private DataContext context = null;

        // constructor setting the context
        public EmployeeController(DataContext context)
        {
            this.context = context;
        }
    
        // http request downloading table content
        [HttpGet]
        public async Task<ActionResult<List<Employee>>> Get()
        {
            return Ok(await this.context.Employees.ToListAsync());
        }

        // http request downloading single item from the table
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> Get(int id)
        {
            var employee = await this.context.Employees.FindAsync(id);
            if(employee == null) 
                return BadRequest("Employee not found");
            return Ok(employee);
        }

        // http request posting object to the table
        [HttpPost]
        public async Task<ActionResult<List<Employee>>> AddHero(Employee employee)
        {
            this.context.Employees.Add(employee);
            await this.context.SaveChangesAsync();

            return Ok(await this.context.Employees.ToListAsync());
        }

        // http request replacing object of the table
        [HttpPut]
        public async Task<ActionResult<List<Employee>>> UpdateHero(Employee request){
            var dbEmployee = await this.context.Employees.FindAsync(request.Id);
            if(dbEmployee == null) 
                return BadRequest("Employee not found");

            dbEmployee.FirstName = request.FirstName;
            dbEmployee.LastName = request.LastName;
            dbEmployee.Adress = request.Adress;
            dbEmployee.DateBirth = request.DateBirth;
            dbEmployee.DateEntry = request.DateEntry;
            dbEmployee.Position = request.Position;
            dbEmployee.Flat = request.Flat;

            await this.context.SaveChangesAsync();

            return Ok(await this.context.Employees.ToListAsync());
        }

        // http request deleting object of the table
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Employee>>> Delete(int id){
            var dbEmployee = await this.context.Employees.FindAsync(id);

            if(dbEmployee == null)
                return BadRequest("Employee not found");

            this.context.Employees.Remove(dbEmployee);
            await this.context.SaveChangesAsync();

            return Ok(await this.context.Employees.ToListAsync());
        }
    }
}