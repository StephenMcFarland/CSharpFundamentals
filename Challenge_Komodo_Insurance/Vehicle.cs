namespace Challenge_Komodo_Insurance
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        public Vehicle() { }

        public Vehicle(string make, string model, int year, int mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
        }
    }
}