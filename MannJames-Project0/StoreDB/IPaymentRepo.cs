using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDB
{
    public interface IPaymentRepo
    {
        void AddPayment(CardPayment cardPayment);
        List<CardPayment> GetCardPayments(int customerId);
    }
}
