using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_Military_Elite
{
    class Program
    {
        static void Main()
        {
            var soldiers = new List<ISoldier>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") { break; }

                string[] inputSplitted = input.Split(" ");

                var soldierTypeFromInput = inputSplitted[0];
                var soldierId = int.Parse(inputSplitted[1]);
                var soldieFN = inputSplitted[2];
                var soldierLN = inputSplitted[3];

                if (soldierTypeFromInput == "Private")
                {
                    var privateSalary = inputSplitted[4];

                    var currentPrivate = new Private(soldierId, soldieFN, soldierLN);
                    currentPrivate.Salary = double.Parse(privateSalary);

                    soldiers.Add(currentPrivate);
                }

                if (soldierTypeFromInput == "LieutenantGeneral")
                {
                    var currentLieutenantGeneral = new LeutenantGeneral(soldierId, soldieFN, soldierLN);
                    currentLieutenantGeneral.Salary = double.Parse(inputSplitted[4]);

                    var lieutenantGeneralPrivateIds = new List<int>();

                    for (int i = 5; i < inputSplitted.Length; i++)
                    {
                        lieutenantGeneralPrivateIds.Add(int.Parse(inputSplitted[i]));
                    }

                    for (int j = 0; j < lieutenantGeneralPrivateIds.Count; j++)
                    {
                        var privateToAdd = soldiers
                            .Where(x => x.Id == lieutenantGeneralPrivateIds[j])
                            .Select(y => y)
                            .FirstOrDefault();

                        currentLieutenantGeneral.Privates.Add(privateToAdd);
                    }

                    soldiers.Add(currentLieutenantGeneral);
                }

                if (soldierTypeFromInput == "Engineer")
                {
                    var isValidCorps = Enum.TryParse(inputSplitted[5], out CorpsType corpsType);

                    if (isValidCorps)
                    {
                        var currentEngineer = new Engineer(soldierId, soldieFN, soldierLN);
                        currentEngineer.Salary = double.Parse(inputSplitted[4]);
                        currentEngineer.Corps = corpsType;

                        for (int i = 6; i < inputSplitted.Length - 1; i += 2)
                        {
                            currentEngineer.Repairs.Add(new Repair()
                            {
                                PartName = inputSplitted[i],
                                HoursWorked = int.Parse(inputSplitted[i + 1])
                            });
                        }

                        soldiers.Add(currentEngineer);
                    }
                }

                if (soldierTypeFromInput == "Commando")
                {
                    var isValidCorps = Enum.TryParse(inputSplitted[5], out CorpsType corpsType);

                    if (isValidCorps)
                    {
                        var currentCommando = new Commando(soldierId, soldieFN, soldierLN);
                        currentCommando.Salary = double.Parse(inputSplitted[4]);

                        for (int i = 6; i < inputSplitted.Length - 1; i += 2)
                        {
                            var isValidMission = Enum.TryParse(inputSplitted[i + 1], out StateType stateType);
                            if (isValidMission)
                            {
                                if (stateType == StateType.finished)
                                {
                                    for (int j = 0; j < soldiers.Count; j++)
                                    {
                                        if (soldiers[j].GetType() == typeof(ICommando))
                                        {
                                            var castedCommando = (Commando)soldiers[j];
                                            var isCodeNameFound = castedCommando.Missions.Where(x => x.CodeName == inputSplitted[i]).Count() != 0;
                                            if (isCodeNameFound)
                                            {
                                                castedCommando.Missions.Where(x => x.CodeName == inputSplitted[i]).FirstOrDefault().CompleteMission();
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    var currentMission = new Mission(inputSplitted[i], stateType);

                                    currentCommando.Missions.Add(currentMission);
                                }
                            }
                        }

                        soldiers.Add(currentCommando);
                    }
                }

                if (soldierTypeFromInput == "Spy")
                {
                    var currentSpy = new Spy(soldierId, soldieFN, soldierLN);
                    currentSpy.CodeNumber = inputSplitted[4];

                    soldiers.Add(currentSpy);
                }
            }

            foreach (var item in soldiers)
            {
                Console.Write(item.ToString());
            }
        }
    }
}
