using static Plant_Radiation_Project.Excecute;

namespace Plant_Radiation_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Excecute ex = new Excecute();
                List<string> lines = ex.ReadFile();
                ex.Ecosystem(ref lines);
            }

            catch (EmptyFileNameException e)
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