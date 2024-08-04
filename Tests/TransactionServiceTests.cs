using Application.Services;
using Core.Entities;
using Core.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class TransactionServiceTests
    {
        private readonly Mock<ITransactionRepository> _mockRepo;
        private readonly TransactionService _service;

        public TransactionServiceTests()
        {
            _mockRepo = new Mock<ITransactionRepository>();
            _service = new TransactionService(_mockRepo.Object);
        }

        [Fact]
        public void AddTransaction_ShouldCallRepository()
        {
            var transaction = new Transaction { Id = Guid.NewGuid(), Date = DateTime.Now, Amount = 100, Type = "credit" };

            _service.AddTransaction(transaction);

            _mockRepo.Verify(repo => repo.AddTransaction(transaction), Times.Once);
        }

        [Fact]
        public void GetDailyConsolidatedAmount_ShouldReturnCorrectAmount()
        {
            var date = DateTime.Now;
            var transactions = new List<Transaction>
            {
                new Transaction { Id = Guid.NewGuid(), Date = date, Amount = 100, Type = "credit" },
                new Transaction { Id = Guid.NewGuid(), Date = date, Amount = 50, Type = "debit" }
            };
            _mockRepo.Setup(repo => repo.GetTransactions(date)).Returns(transactions);

            var result = _service.GetDailyConsolidatedAmount(date);

            Assert.Equal(50, result);
        }
    }
}
