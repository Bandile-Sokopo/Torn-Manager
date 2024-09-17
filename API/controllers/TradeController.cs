﻿using Api.Controllers;
using API.Data;
using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.controllers
{
    public class TradeController:BaseApiController
    {
        DataContext _context;

        public TradeController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<TradeDto> AddTrade(Trade trade)
        {

        }
    }
}
