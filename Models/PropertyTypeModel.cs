
namespace PropertiesManagement.Models
{
    public class PropertyTypeModel
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public virtual ICollection<PropertyTypeModel> Properties { get; set; } = new List<PropertyTypeModel>();
    }
}
