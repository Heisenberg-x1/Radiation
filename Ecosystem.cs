using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFile;

namespace Plant_Radiation_Project
{
    public class Ecosystem
    {
        public string Filename()
        {
            Console.Write("Enter filename: ");
            string filename = Console.ReadLine();
            return filename;
        }
        public List<string> ReadFile(string filename)
        {


            if (string.IsNullOrEmpty(filename))
            {
                throw new ArgumentException("No file name was passed");
            }
            else if (!string.IsNullOrEmpty(filename) && !File.Exists(filename))
            {
                throw new FileNotFoundException(filename);
            }
            TextFileReader reader = new TextFileReader(filename);
            List<string> lines = new List<string>();
            while (reader.ReadLine(out string line))
            {
                lines.Add(line);
            }
            return lines;
        }
        public void Simulate(ref List<string> lines)
        {
            //DISPLAY THE CONTENT OF THE FILE
            Console.WriteLine("Content of the file:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            int days = 1;
            Console.WriteLine($"Day {days} radiation: no radiation\n");

            lines.RemoveAt(0);
            string radiation = "no radiation";
            int numberOfDaysWithNoRad = 1;

            while (numberOfDaysWithNoRad < 2)
            {
                int alphademand = 0;
                int deltademand = 0;
                string temp_next_day = "";
                switch (radiation)
                {
                    case "no radiation":
                        for (int i = 0; i < lines.Count; i++)
                        {
                            string name = lines[i].Split(' ')[0];
                            string species = lines[i].Split(" ")[1];
                            int level = int.Parse(lines[i].Split(' ')[2]);
                            NoRadiation no = new NoRadiation();
                            switch (species)
                            {
                                case "wom":
                                    Wombleroot wom = new Wombleroot(name, level);
                                    int new_level = wom.Traverse(no);
                                    if (wom.isAlive)
                                    {
                                        lines[i] = name + " " + species + " " + new_level;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                    alphademand += wom.AlphaDemand();

                                    break;
                                case "wit":
                                    Wittentoot wit = new Wittentoot(name, level);
                                    int newLevel1 = wit.Traverse(no);
                                    if (wit.isAlive)
                                    {
                                        lines[i] = name + " " + species + " " + newLevel1;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                    deltademand += wit.DeltaDemand();
                                    break;
                                case "wor":
                                    Woreroot wor = new Woreroot(name, level);
                                    int newLevel2 = wor.Traverse(no);
                                    if (wor.isAlive)
                                    {
                                        lines[i] = name + " " + species + " " + newLevel2;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                    break;
                            }
                        }
                        NextDayRad next1 = new NextDayRad(alphademand, deltademand);
                        temp_next_day = next1.Radiation();
                        if (temp_next_day == "no radiation")
                        {
                            numberOfDaysWithNoRad++;
                        }
                        else
                        {
                            numberOfDaysWithNoRad = 0;
                        }


                        //PRINT THE DATA
                        Console.WriteLine($"Day :{days++}\n");
                        for (int i = 0; i < lines.Count; i++)
                        {
                            Console.WriteLine(lines[i]);
                        }
                        Console.WriteLine("Next day radiation: " + temp_next_day + "\n");
                        break;
                    case "alpha":
                        for (int i = 0; i < lines.Count; i++)
                        {
                            string name = lines[i].Split(' ')[0];
                            string species = lines[i].Split(" ")[1];
                            int level = int.Parse(lines[i].Split(' ')[2]);
                            Alpha alpha = new Alpha();

                            switch (species)
                            {
                                case "wom":
                                    Wombleroot wom = new Wombleroot(name, level);
                                    int newLevel = wom.Traverse(alpha);
                                    if (wom.isAlive)
                                    {
                                        lines[i] = name + " " + species + " " + newLevel;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                    alphademand += wom.AlphaDemand();
                                    break;
                                case "wit":
                                    Wittentoot wit = new Wittentoot(name, level);
                                    int newLevel1 = wit.Traverse(alpha);
                                    if (wit.isAlive)
                                    {
                                        lines[i] = name + " " + species + " " + newLevel1;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                    deltademand += wit.DeltaDemand();
                                    break;
                                case "wor":
                                    Woreroot wor = new Woreroot(name, level);
                                    int newLevel2 = wor.Traverse(alpha);
                                    if (wor.isAlive)
                                    {
                                        lines[i] = name + " " + species + " " + newLevel2;
                                    }
                                    else
                                    {
                                        continue;
                                    }

                                    break;
                            }

                        }
                        NextDayRad next2 = new NextDayRad(alphademand, deltademand);
                        temp_next_day = next2.Radiation();
                        if (temp_next_day == "no radiation")
                        {
                            numberOfDaysWithNoRad++;
                        }
                        else
                        {
                            numberOfDaysWithNoRad = 0;
                        }
                        //PRINT THE DATA
                        Console.WriteLine($"Day {days++}:\n");
                        for (int i = 0; i < lines.Count; i++)
                        {
                            Console.WriteLine(lines[i]);
                        }
                        Console.WriteLine("Next day radiation: " + temp_next_day + "\n");

                        break;
                    case "delta":
                        for (int i = 0; i < lines.Count; i++)
                        {
                            string name = lines[i].Split(' ')[0];
                            string species = lines[i].Split(" ")[1];
                            int level = int.Parse(lines[i].Split(' ')[2]);
                            Delta delta = new Delta();

                            switch (species)
                            {
                                case "wom":
                                    Wombleroot wom = new Wombleroot(name, level);
                                    int newLevel = wom.Traverse(delta);
                                    if (wom.isAlive)
                                    {
                                        lines[i] = name + " " + species + " " + newLevel;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                    alphademand += wom.AlphaDemand();
                                    break;
                                case "wit":
                                    Wittentoot wit = new Wittentoot(name, level);
                                    int newLevel1 = wit.Traverse(delta);
                                    if (wit.isAlive)
                                    {
                                        lines[i] = name + " " + species + " " + newLevel1;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                    deltademand += wit.DeltaDemand();
                                    break;
                                case "wor":
                                    Woreroot wor = new Woreroot(name, level);
                                    int newLevel2 = wor.Traverse(delta);
                                    if (wor.isAlive)
                                    {
                                        lines[i] = name + " " + species + " " + newLevel2;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                    break;
                            }

                        }
                        NextDayRad next3 = new NextDayRad(alphademand, deltademand);
                        temp_next_day = next3.Radiation();
                        if (temp_next_day == "no radiation")
                        {
                            numberOfDaysWithNoRad++;
                        }
                        else
                        {
                            numberOfDaysWithNoRad = 0;
                        }
                        //PRINT THE DATA
                        Console.WriteLine($"Day {days++}:\n");
                        for (int i = 0; i < lines.Count; i++)
                        {
                            Console.WriteLine(lines[i]);
                        }
                        Console.WriteLine("Next day radiation: " + temp_next_day + "\n");

                        break;

                }
                radiation = temp_next_day;


            }
            Console.WriteLine("Exit successfully!Found 2 days with no radiation");
        }

    }
}