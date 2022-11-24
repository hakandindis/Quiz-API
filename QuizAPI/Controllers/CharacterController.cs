using Microsoft.AspNetCore.Mvc;

namespace QuizAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static readonly string[] Names = new[]
        {
        "Hakan", "Kaan", "Can", "Refik", "Ulaş" };

            private static readonly string[] Films = new[]
        {
        "Star Wars", "Lotr", "Matrix", "Lucy", "Mild"
    };

        private readonly ILogger<CharacterController> _logger;

        public CharacterController(ILogger<CharacterController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "character")]
        public IEnumerable<Character> Get()
        {
            return Enumerable.Range(1, 4).Select(index => new Character
            {
                Id = index,
                Name = Names[index],
                Film = Films[index]
            })
            .ToArray();
        }
    }
}
