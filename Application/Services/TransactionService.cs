using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;

namespace Application.Services
{
    public class TransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public void AddTransaction(Transaction transaction)
        {
            _transactionRepository.AddTransaction(transaction);
        }

        public decimal GetDailyConsolidatedAmount(DateTime date)
        {
            var transactions = _transactionRepository.GetTransactions(date);
            decimal total = 0;
            foreach (var transaction in transactions)
            {
                total += transaction.Type == "credit" ? transaction.Amount : -transaction.Amount;
            }
            return total;
        }
    }
}
