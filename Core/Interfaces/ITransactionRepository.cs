using System.Collections.Generic;
using Core.Entities;

namespace Core.Interfaces
{
    public interface ITransactionRepository
    {
        void AddTransaction(Transaction transaction);
        IEnumerable<Transaction> GetTransactions(DateTime date);
    }
}
