namespace ToyotaCorolla
{
    internal class Corolla : ICorollaProductionRules
    {
        public string carColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string carName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string carEngine { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       
        static void Main(string[] args)
        {
            Corolla corolla = new Corolla();

            Console.WriteLine("You have a car tyre");
            Console.ReadLine();
        }

        public bool carTyre(string carName)
            
        {
            return  true;
        }
    }
}