using System;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {


            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            Rover[] rovers = 
            {
                lunokhod,
                apollo,
                sojourner
            };

            DirectAll(rovers);

            

            Object[] objects = 
            {
                lunokhod,
                apollo,
                sojourner,
                sputnik
            };

            DirectAllPlusSatellite(objects);

            IDirectable[] probes = 
            {
                lunokhod,
                apollo,
                sojourner,
                sputnik
            };

            DirectAllIDirectable(probes);
        }

        static void DirectAll(Rover[] rovers)
        {
            foreach (Rover rover in rovers)
            {
                Console.WriteLine($"Get info: {rover.GetInfo()}\nExplore: {rover.Explore()}\nCollect: {rover.Collect()}");
            }

        }

        static void DirectAllPlusSatellite(Object[] objects)
        {
            foreach (Object o in objects)
            {
                Console.WriteLine($"Tracking a {o.GetType()}");
            }

        }

        static void DirectAllIDirectable(IDirectable[] probes)
        {
            foreach (Rover prob in probes)
            {
                Console.WriteLine($"Get info: {prob.GetInfo()}\nExplore: {prob.Explore()}\nCollect: {prob.Collect()}");
            }

        }
    }
}
