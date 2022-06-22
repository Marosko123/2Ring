using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace newwebapi.Controllers
{
    [Route("newwebapi/[controller]")]
    [ApiController]
    public class PositionsController: ControllerBase
    {
        // context storing database table information
        private DataContextPositions contextPos = null;

        // constructor setting the context
        public PositionsController(DataContextPositions contextPos)
        {
            this.contextPos = contextPos;
        }

        // http request downloading table content
        [HttpGet]
        public async Task<ActionResult<List<Position>>> Get()
        {
            return Ok(await this.contextPos.Positions.ToListAsync());
        }

        // http request downloading single item from the table
        [HttpGet("{id}")]
        public async Task<ActionResult<Position>> Get(int id)
        {
            var position = await this.contextPos.Positions.FindAsync(id);
            if(position == null) 
                return BadRequest("Position not found");
            return Ok(position);
        }

        // http request posting object to the table
        [HttpPost]
        public async Task<ActionResult<List<Position>>> AddPosition(Position position)
        {
            this.contextPos.Positions.Add(position);
            await this.contextPos.SaveChangesAsync();

            return Ok(await this.contextPos.Positions.ToListAsync());
        }

        // http request replacing object of the table
        [HttpPut]
        public async Task<ActionResult<List<Position>>> UpdatePosition(Position request){
            var dbPosition = await this.contextPos.Positions.FindAsync(request.Id);
            if(dbPosition == null) 
                return BadRequest("Position not found");

            dbPosition.PositionName = request.PositionName;
            dbPosition.NumberOfEmployeesOnPos = request.NumberOfEmployeesOnPos;

            await this.contextPos.SaveChangesAsync();

            return Ok(await this.contextPos.Positions.ToListAsync());
        }

        // http request deleting object of the table
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Position>>> Delete(int id){
            var dbPosition = await this.contextPos.Positions.FindAsync(id);

            if(dbPosition == null)
                return BadRequest("Position not found");

            this.contextPos.Positions.Remove(dbPosition);
            await this.contextPos.SaveChangesAsync();

            return Ok(await this.contextPos.Positions.ToListAsync());
        }
    }
}