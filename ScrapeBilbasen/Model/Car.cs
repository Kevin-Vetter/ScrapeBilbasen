namespace ScrapeBilbasen.Model
{
    public class Car
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public List<string> Details { get; set; }
        public string Description { get; set; }
        public List<string> GeneralInfo { get; set; }
        public List<string> Equipment { get; set; }

        public Car(string URL)
        {
            //Id = id;
            //Price = price;
            //Make = make;
            //Model = model;
            //Details = details;
            //Description = description;
            //GeneralInfo = generalInfo;
            //Equipment = equipment;
        }

        public Car(int id, decimal price, string make, string model, List<string> details, string description, List<string> generalInfo, List<string> equipment)
        {
            Id = id;
            Price = price;
            Make = make;
            Model = model;
            Details = details;
            Description = description;
            GeneralInfo = generalInfo;
            Equipment = equipment;
        }

        public Car CreateNewCar()
        {
            return null;
        }
    }
}
