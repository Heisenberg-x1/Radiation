using static Plant_Radiation_Project.Excecute;

namespace Plant_Radiation_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Ecosystem e = new Ecosystem();
                string filename = e.Filename();
                List<string> lines = e.ReadFile(filename);
                e.Simulate(ref lines);
            }

            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }

        }
    }
}