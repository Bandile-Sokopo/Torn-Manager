using Api.Controllers;
using API.Data;
using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using System;

namespace API.Controllers
{
    public class STransactionController : BaseApiController
    {
        private readonly DataContext _context;
        public STransactionController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<StockTransactionDto>> AddStock([FromBody] StockTransactions item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return new StockTransactionDto
            {
                Stock = item.Stock,
                DatePurchased = item.DatePurchased,
                TotalPurchased = item.TotalPurchased,
            };
        }
    }
}
