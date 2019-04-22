using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main()
        {
            string inputtt = Console.ReadLine();

            var sides = new Dictionary<string, List<string>>();

            while (inputtt != "Lumpawaroo")
            {
                if (inputtt.Contains("|"))
                {
                    var input = inputtt.Split(" | ");
                    string forceSide = input[0];
                    string forceUser = input[1];

                    bool isUserExcist = false;

                    //проверяваме дали има такъв User вече
                    foreach (var side in sides)
                    {
                        if (side.Value.Contains(forceUser))
                        {
                            isUserExcist = true;
                        }
                    }
                    if (!sides.ContainsKey(forceSide))
                    {
                        sides.Add(forceSide, new List<string>());
                    }

                    if (!isUserExcist)
                    {

                        sides[forceSide].Add(forceUser);

                    }
                }
                else if (inputtt.Contains("->"))
                {
                    var input = inputtt.Split(" -> ");
                    string forceUser = input[0];
                    string forceSide = input[1];

                    bool isUserExcist = false;

                    //проверяваме дали има такъв User вече
                    foreach (var side in sides)
                    {
                        if (side.Value.Contains(forceUser))
                        {
                            isUserExcist = true;
                        }
                    }

                    if (!sides.ContainsKey(forceSide))
                    {
                        sides.Add(forceSide, new List<string>());
                    }

                    if (!isUserExcist)
                    {
                        if (sides.ContainsKey(forceSide))
                        {
                            sides[forceSide].Add(forceUser);
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        }
                    }
                    else if (isUserExcist)
                    {
                        string sideOfExcistUser = " ";

                        foreach (var side in sides)
                        {
                            if (side.Value.Contains(forceUser))
                            {
                                sideOfExcistUser = side.Key;
                            }
                        }

                        if (sides.ContainsKey(forceSide))
                        {
                            sides[forceSide].Add(forceUser);
                            sides[sideOfExcistUser].Remove(forceUser);
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        }
                    }

                }

                inputtt = Console.ReadLine();

            }


            foreach (var side in sides.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                foreach (var username in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {username}");
                }
            }
        }
    }
}