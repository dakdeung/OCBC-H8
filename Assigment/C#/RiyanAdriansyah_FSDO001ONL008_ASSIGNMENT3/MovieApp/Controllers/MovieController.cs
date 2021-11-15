using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private MovieContext _context;

        public MovieController(MovieContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MovieData>> GetAllMovie()
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.GetAllMovie();
        }

        [HttpPost]
        public ActionResult<IEnumerable<MovieData>> PostMovies(MovieData data)
        {
            if(ModelState.IsValid)
            {
                _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
                return _context.PostMovie(data);
            }
            return new JsonResult("Something went wrong") {StatusCode = 500};
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<MovieData>> GetMovie(string id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.GetMovie(id);
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable<MovieData>> PutMovie(MovieData data, string id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.PutMovie(data, id);
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<MovieData>> DeleteMovie(string id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.DeleteMovie(id);
        }
        
    }
}
