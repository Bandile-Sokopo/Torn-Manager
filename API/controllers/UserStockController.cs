using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.controllers
{
    public class UserStockController
    {
        private readonly DataContext _context;
        public UserStockController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult<UserStocks> AddStock([FromBody] UserStocks item) { }

        [HttpPut]
        public IActionResult<UserStocks> UpdateStock([FromBody] UserStocks item) { }
    }
}
