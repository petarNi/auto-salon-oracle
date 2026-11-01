using Microsoft.AspNetCore.Mvc;
using SalonLibrary;
using SalonLibrary.DTOs;

namespace SalonWebApiService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalonController : ControllerBase
    {
        [HttpGet("VratiSveSalone")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> GetSaloni()
        {
            var (isError, saloni, error) = await DataProvider.VratiSveSalone();

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(saloni);
        }

        [HttpPost]
        [Route("DodajSalon")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddSalon([FromBody] SalonView p)
        {
            var data = await DataProvider.DodajSalon(p);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(201, $"Uspešno dodata prodavnica. Naziv: {p.Naziv}");
        }

        [HttpDelete]
        [Route("ObrisiSalon/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteSalon(int id)
        {
            var data = await DataProvider.ObrisiSalon(id);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(204, $"Uspešno obrisana salon. ID: {id}");
        }


        [HttpPut]
        [Route("AzurirajSalon")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> UpdateSalon([FromBody] SalonView s)
        {
            (bool isError, var salon, var error) = await DataProvider.AzurirajSalonAsync(s);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(salon);
        }

        [HttpGet("VratiSalon")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> GetSalon(int id)
        {
            var (isError, salon, error) = await DataProvider.VratiSalonPoId(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(salon);
        }
    }
}
