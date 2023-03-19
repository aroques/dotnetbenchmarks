namespace Benchmarks.Util.Models
{
    public class DataModel
    {
        public int Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
        public string? CreateUser { get; set; } = string.Empty;
        public DateTime ModifyDateTime { get; set; } = DateTime.Now;
        public string? ModifyUser { get; set; } = string.Empty;
    }
}
