namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleData sampleData = new SampleData();
            foreach (var item in sampleData.GetDepartments())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}