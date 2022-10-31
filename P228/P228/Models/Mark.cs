using System.Collections.Generic;

namespace P228.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public List<Car> Cars { get; set; }
    }
}
