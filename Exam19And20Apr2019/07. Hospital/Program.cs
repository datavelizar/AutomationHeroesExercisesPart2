using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();
            int patientId = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input != "Output")
                {
                    string departmentName, doctorFirstName, doctorLastName, patientName;
                    ProcessBasicInput(input, out departmentName, out doctorFirstName, out doctorLastName, out patientName);

                    var currentPatient = new Patient //Patient name is unique
                    {
                        Name = patientName,
                        Id = patientId,
                    };

                    Department currentDepartment = hospital.departments.Find(x => x.Name == departmentName);

                    if (currentDepartment != null)
                    {
                        if (currentDepartment.patients.Count < 60)
                        {
                            currentDepartment.patients.Add(currentPatient);
                        }
                    }
                    else
                    {
                        currentDepartment = new Department { Name = departmentName };
                        currentDepartment.patients.Add(currentPatient);
                        hospital.departments.Add(currentDepartment);
                    }

                    Doctor currentDoctor = hospital.doctors.Find(x => x.FullName == (doctorFirstName + " " + doctorLastName));

                    if (currentDoctor != null)
                    {
                        if (currentDepartment.patients.Count <= 60)
                        {
                            currentDoctor.patients.Add(currentPatient);
                        }
                    }
                    else
                    {
                        currentDoctor = new Doctor(doctorFirstName, doctorLastName);
                        currentDoctor.patients.Add(currentPatient);
                        hospital.doctors.Add(currentDoctor);
                    }

                    patientId++;
                }
                else
                {
                    while (true)
                    {
                        string command = Console.ReadLine();

                        if (command != "End")
                        {
                            string[] splittedCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                            if (splittedCommand.Length == 1)//it is department => print all patients in this department in order of receiving on new line
                            {
                                var departmentName = splittedCommand[0].TrimEnd();
                                Department departmentToPrint = hospital.departments.Find(x => x.Name == departmentName);
                                for (int i = 0; i < departmentToPrint.patients.Count; i++)
                                {
                                    Console.WriteLine(departmentToPrint.patients[i].Name);
                                }
                            }
                            else
                            {
                                if (splittedCommand.Length == 2)
                                {
                                    bool hasRoom = int.TryParse(splittedCommand[1], out int roomNumber);

                                    if (hasRoom)  //{Department} {Room} – print all patients in this room in alphabetical order each on new line
                                    {
                                        var departmentName = splittedCommand[0].TrimEnd();
                                        var departmentToPrint = hospital.departments.Find(x => x.Name == departmentName);
                                        var endIndexToPrint = roomNumber * 3;//58, 59 are in room number 20
                                        var patientsToPrint = new List<Patient>();
                                        for (int i = endIndexToPrint - 3; i < endIndexToPrint; i++)
                                        {
                                            if (departmentToPrint.patients[i] != null)
                                            {
                                                patientsToPrint.Add(departmentToPrint.patients[i]);
                                            }
                                        }

                                        var sorted = patientsToPrint.OrderBy(x => x.Name).ToList();

                                        for (int i = 0; i < sorted.Count; i++)
                                        {
                                            Console.WriteLine(sorted[i].Name);
                                        }


                                    }
                                    else  //it is Doctor => {Doctor} – print all patients that are healed from doctor in alphabetical order on new line
                                    {
                                        var doctorFirstName = splittedCommand[0].TrimEnd();
                                        var doctorLastName = splittedCommand[1].TrimEnd();

                                        Doctor doctorToPrint = hospital.doctors.Find(x => x.FullName == doctorFirstName + " " + doctorLastName);

                                        var sorted = doctorToPrint.patients.OrderBy(x => x.Name).ToList();

                                        for (int i = 0; i < sorted.Count; i++)
                                        {
                                            Console.WriteLine(sorted[i].Name);
                                        }

                                    }
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    break;
                }
            }
        }

        private static void ProcessBasicInput(string input, out string departmentName, out string doctorFirstName, out string doctorLastName, out string patientName)
        {
            string[] splitted = input.Split(" ");
            departmentName = splitted[0];
            doctorFirstName = splitted[1];
            doctorLastName = splitted[2];
            patientName = splitted[3];
        }
    }

    public class Hospital
    {
        public List<Department> departments = new List<Department>();
        public List<Doctor> doctors = new List<Doctor>();
    }

    public class Department
    {
        public string Name { get; set; }
        public List<Patient> patients = new List<Patient>();
    }


    public class Doctor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Patient> patients = new List<Patient>();
        public string FullName { get; set; } // = FirstName + " " + LastName;

        public Doctor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = firstName + " " + lastName;
        }
    }

    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}