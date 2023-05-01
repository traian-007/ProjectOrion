namespace Orion.Domain.Entities.Base
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            UpdatedOnUtc = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; private set; }
    }
}
