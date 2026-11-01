using Microsoft.AspNetCore.Mvc;
using SalonLibrary;
using SalonLibrary.DTOs;

namespace SalonWebApiService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ZaposleniController : ControllerBase
    {
        [HttpGet("VratiSveZaposlene")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetZaposleni()
        {
            var (isError, zaposleni, error) = await DataProvider.VratiSveZaposlene();

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(zaposleni);
        }

        [HttpGet("VratiZaposlenogPoJMBG")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetZaposleni(string jmbg)
        {
            var (isError, zaposleni, error) = await DataProvider.VratiZaposlenogPoJMBG(jmbg);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(zaposleni);
        }

        [HttpPost]
        [Route("DodajZaposlenog")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddZaposleni([FromBody] ZaposleniView zaposleni)
        {
            var data = await DataProvider.DodajZaposlenog(zaposleni);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(201, "Uspešno dodat zaposleni.");
        }

        [HttpPut]
        [Route("AzurirajZaposlenog")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> UpdateZaposleni([FromBody] ZaposleniView zaposleni)
        {
            (bool isError, var z, var error) = await DataProvider.AzurirajZaposlenogAsync(zaposleni);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(z);
        }

        [HttpDelete]
        [Route("ObrisiSalon/{jmbg}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteZaposleni(string jmbg)
        {
            var data = await DataProvider.ObrisiZaposlenog(jmbg);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(204, $"Uspešno obrisan zaposleni. JMBG: {jmbg}");
        }
    }
}
