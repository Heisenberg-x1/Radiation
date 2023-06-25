# Plant Radiation Simulation

This is a C# program that simulates an ecosystem of plants on a planet with different kinds of radiation. The program reads data from a text file and simulates the ecosystem until there is no radiation on two consecutive days.

## Installation
To run the program, you will need to have the .NET Framework installed on your computer. Once you have installed the .NET Framework, you can compile and run the program using the following commands:

*csc Program.cs*    

*Program.exe*

## Usage
To use the program, you will need to create a text file with the data for the simulation. The first line of the file should contain the number of plants in the ecosystem. Each subsequent line should contain the data for one plant, including its name, species, and starting nutrient level.

The species codes for the different kinds of plants are as follows:

*wom: Wombleroot*
*wit: Wittentoot*
*wor: Woreroot*

Once you have created the input file, you can run the program and enter the filename when prompted. The program will read the data from the file and simulate the ecosystem until there is no radiation on two consecutive days.

The program will output the data for each day of the simulation, including the nutrient levels of each plant and the level of radiation for that day.
