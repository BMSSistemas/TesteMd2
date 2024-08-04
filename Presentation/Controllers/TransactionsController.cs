using Application.Services;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly TransactionService _transactionService;

        public TransactionsController(TransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost]
        public IActionResult AddTransaction([FromBody] Transaction transaction)
        {
            _transactionService.AddTransaction(transaction);
            return Ok();
        }

        [HttpGet("consolidated")]
        public IActionResult GetDailyConsolidatedAmount([FromQuery] DateTime date)
        {
            var total = _transactionService.GetDailyConsolidatedAmount(date);
            return Ok(total);
        }
    }
}
