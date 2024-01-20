

namespace PropertiesManagement.Models
{
    public class OwnerModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Telephone { get; set; }

        public string? Email { get; set; }

        public string? IdentificationNumber { get; set; }

        public string? Address { get; set; }

        public virtual ICollection<PropertyModel> Properties { get; set; } = new List<PropertyModel>();
    }
}
