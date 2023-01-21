using WIMD.Domain.SeedWork;

namespace WIMD.Domain.SharedKernel
{
    public class DateOfBirth : ValueObject
    {
        private readonly DateTime Value;

        public DateOfBirth(DateTime value)
        {
            Value = value;
        }
    }
}
