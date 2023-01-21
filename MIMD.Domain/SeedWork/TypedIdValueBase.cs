namespace WIMD.Domain.SeedWork
{
    public abstract class TypedIdValueBase : IEquatable<TypedIdValueBase>
    {
        public Guid Value { get; }

        protected TypedIdValueBase(Guid value)
        {
            Value = value;
        }

        public bool Equals(object obj)
        {
            if(ReferenceEquals(null, obj)) return false;
            return obj is TypedIdValueBase other && Equals((other));
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public bool Equals(TypedIdValueBase other)
        {
            return Value == other.Value;
        }

        public static bool operator !=(TypedIdValueBase x, TypedIdValueBase y)
        {
            return !(x == y);
        }

        public static bool operator ==(TypedIdValueBase x, TypedIdValueBase y)
        {
            return x == y;
        }
    }
}
