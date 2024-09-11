using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HttpMetodeController : ControllerBase
    {
        //ovdje počinje ruta

        [HttpGet]
        public string Pozdravi()
        {
            return "Hello";
        }

        // ovdje završava


        //ovdje počinje ruta
        [HttpGet]
        [Route("Pozdrav")]

        public string Pozdravi(string s)
        {
            return "Hello " + s;
        }
        // ovdje završava


        [HttpGet]
        [Route("Hello")]
        public IActionResult Pozdravi(int id, string ime)
        {
            return Ok(new {sifra = id, naziv = ime});
        }
    }
}