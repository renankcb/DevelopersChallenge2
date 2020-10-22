using System;
using System.Diagnostics.CodeAnalysis;

namespace BankReconciliation.Domain.Entities
{
    public class BankAccount : IEquatable<BankAccount>
    {
        public int BankCode { get; set; }

        public int AccountId { get; set; }

        public string Type { get; set; }

        public bool Equals([AllowNull] BankAccount other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return BankCode.Equals(other.BankCode) && AccountId.Equals(other.AccountId) && Type.Equals(other.Type);
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((BankAccount)obj);
        }

        public override int GetHashCode()
        {
            int hashType = Type == null ? 0 : Type.GetHashCode();
            int hashBankCode = BankCode.GetHashCode();
            int hashAccountId = AccountId.GetHashCode();

            return hashType ^ hashBankCode ^ hashAccountId;
        }
    }
}
