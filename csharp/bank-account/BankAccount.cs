namespace Exercism_bank_account
{
    using System;

    public class BankAccount
    {
        private double _balance;

        private readonly object thisLock = new object();

        public bool IsActive { get; private set; }

        public double Balance
        {
            get
            {
                if (!IsActive)
                {
                    throw new InvalidOperationException("Bank account is inactive");
                }

                return _balance;
            }
        }

        public void Close()
        {
            IsActive = false;

            _balance = 0;
        }

        public void Open()
        {
            IsActive = true;
        }

        public void UpdateBalance(double val)
        {
            lock(thisLock)
            {
                _balance += val;
            }
        }
    }
}
