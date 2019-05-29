using P08._Military_Elite.Contracts;
using P08._Military_Elite.Models;
using System;
using System.Collections.Generic;

namespace P08._Military_Elite
{
    class Program
    {
        static void Main(string[] args)
        {
            var privates = new List<IPrivate>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") { break; }

                string[] inputSplitted = input.Split(" ");

                var soldierTypeInCommand = inputSplitted[0];

                if (soldierTypeInCommand == "Private")
                {
                    //Private: “Private<id> < firstName > < lastName > < salary >”
                    var privateId = int.Parse(inputSplitted[1]);
                    var privateFN = inputSplitted[2];
                    var privateLN = inputSplitted[3];
                    var privateSalary = inputSplitted[4];

                    var currentPrivate = new Private();
                    currentPrivate.Id = privateId;
                    currentPrivate.FirstName = privateFN;
                    currentPrivate.LastName = privateLN;
                    currentPrivate.Salary = double.Parse(privateSalary);

                    privates.Add(currentPrivate);
                }

                if (soldierTypeInCommand == "LieutenantGeneral")
                {
                    //LeutenantGeneral: “LieutenantGeneral<id> 
                    //< firstName > < lastName > < salary > < private1Id > < private2Id > … < privateNId >” 
                    //where privateXId will always be an Id of a private already received through the input.
                    var lieutenantGeneralId = inputSplitted[1];
                    var lieutenantGeneralFN = inputSplitted[2];
                    var lieutenantGeneralLN = inputSplitted[3];
                    var lieutenantGeneralSalary = inputSplitted[4];

                    var lieutenantGeneralPrivateIds = new List<int>();

                    for (int i = 5; i < inputSplitted.Length; i++)
                    {
                        lieutenantGeneralPrivateIds.Add(int.Parse(inputSplitted[i]));
                    }
                }

                if (soldierTypeInCommand == "Engineer")
                {
                    // Engineer: “Engineer<id>
                    //< firstName > < lastName > < salary > < corps > < repair1Part > < repair1Hours > … < repairNPart > < repairNHours >” 
                    //where repairXPart is the name of a repaired part and repairXHours the hours it took to repair it(the two parameters will always come paired).
                    var engineerId = inputSplitted[1];
                    var engineerFN = inputSplitted[2];
                    var engineerLN = inputSplitted[3];
                    var engineerSalary = inputSplitted[4];
                    var engineerCorps = inputSplitted[5];

                    var engineerRepairPartHours = new Dictionary<string, int>();

                    for (int i = 6; i < inputSplitted.Length - 1; i += 2)
                    {
                        engineerRepairPartHours.Add(inputSplitted[i], int.Parse(inputSplitted[i + 1]));
                    }
                }

                if (soldierTypeInCommand == "Commando")
                {
                    //Commando: “Commando<id> 
                    //< firstName > < lastName > < salary > < corps > < mission1CodeName >  < mission1state > … < missionNCodeName > < missionNstate >” 
                    //a missions cde name, description and state will always come together.
                    var commandoId = inputSplitted[1];
                    var commandoFN = inputSplitted[2];
                    var commandoLN = inputSplitted[3];
                    var commandoSalary = inputSplitted[4];
                    var commandoCorps = inputSplitted[5];

                    var commandoMissionNameState = new Dictionary<string, string>();

                    for (int i = 6; i < inputSplitted.Length - 1; i += 2)
                    {
                        commandoMissionNameState.Add(inputSplitted[i], inputSplitted[i + 1]);
                    }

                }

                if (soldierTypeInCommand == "Spy")
                {
                    // Spy: “Spy<id> < firstName > < lastName > < codeNumber >”
                    var spyId = inputSplitted[1];
                    var spyFN = inputSplitted[2];
                    var spyLN = inputSplitted[3];
                    var spyCodeNumber = inputSplitted[4];
                }
            }

            foreach (var item in privates)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
