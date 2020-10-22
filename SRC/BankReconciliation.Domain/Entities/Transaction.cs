using System;
using System.Diagnostics.CodeAnalysis;

namespace BankReconciliation.Domain.Entities
{
    public class Transaction : IEquatable<Transaction>
    {
        public string Type { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public double Value { get; set; }

        public bool Equals([AllowNull] Transaction other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Type.Equals(other.Type) && Description.Equals(other.Description) && Value.Equals(other.Value) && Date.Equals(other.Date);
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

            return Equals((Transaction)obj);
        }

        public override int GetHashCode()
        {
            int hashType = Type == null ? 0 : Type.GetHashCode();
            int hashDate = Date == null ? 0 : Date.GetHashCode();
            int hashDescription = Description == null ? 0 : Description.GetHashCode();
            int hashValue = Value.GetHashCode();

            return hashType ^ hashDate ^ hashDescription ^ hashValue;
        }
    }
}
