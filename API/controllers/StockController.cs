using Api.Controllers;
using API.Data;
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
        public IActionResult<OwnedStocks> AddStock([FromBody] StockTransactions item) { }
    }
}
