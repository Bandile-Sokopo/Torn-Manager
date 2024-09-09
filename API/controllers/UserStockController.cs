using API.Data;
using API.DTOs;
using API.Entities;
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
        public async Task<ActionResult<OwnedStockDto>> AddStock([FromBody] OwnedStocks item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return new OwnedStockDto
            {
                Stock = item.Stock,
                TotalOwned = item.TotalOwned,
            };
        }

        [HttpPut]
        public IActionResult<UserStocks> UpdateStock([FromBody] UserStocks item)
        {

        }
    }
}
