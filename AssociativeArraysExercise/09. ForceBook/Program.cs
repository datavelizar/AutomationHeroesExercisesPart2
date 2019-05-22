using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string sideSplitter = " | ";
            string userSplitter = " -> ";

            Dictionary<string, List<string>> sideAndUsers = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Lumpawaroo")
                {
                    break;
                }

                SplitInput(sideSplitter, userSplitter, input, out string side, out string user, out bool isSideSplitter);

                if (isSideSplitter) // {forceSide} | {forceUser}   
                {
                    DealWhenSideSplitter(sideAndUsers, side, user);
                }
                else // {forceUser} -> {forceSide} 
                {
                    DealWhenUserSplitter(sideAndUsers, side, user);
                }
            }

            Print(sideAndUsers);
        }

        private static void RemoveUser(Dictionary<string, List<string>> sideAndUsers, string user)
        {
            foreach (var listOfUsers in sideAndUsers.Values)
            {
                if (listOfUsers.IndexOf(user) != -1)
                {
                    listOfUsers.Remove(user);
                }
            }
        }
       
        private static void DealWhenSideSplitter(Dictionary<string, List<string>> sideAndUsers, string side, string user)
        {
            if (!(sideAndUsers.Values.Any(x => x.IndexOf(user) != -1))) // new side | existing user
            {
                // If you receive forceSide | forceUser you should check if such forceUser already exists, and if not, add him/her to the corresponding side.
                if (sideAndUsers.Keys.Any(x => x == side)) // existing side
                {
                    sideAndUsers[side].Add(user); // existing side | new user
                }
                else // new side
                {
                    sideAndUsers.Add(side, new List<string>() { user }); // new side | new user

                }
            }
        }

        private static void DealWhenUserSplitter(Dictionary<string, List<string>> sideAndUsers, string side, string user)
        {
            if (sideAndUsers.Values.Any(x => x.IndexOf(user) != -1))
            {
                RemoveUser(sideAndUsers, user);
            }

            if (sideAndUsers.Keys.Any(x => x == side)) // existing side
            {
                sideAndUsers[side].Add(user);
            }
            else // new site
            {
                sideAndUsers.Add(side, new List<string>() { user });
            }

            Console.WriteLine($"{user} joins the {side} side!");
        }

        private static void SplitInput(string sideSpltter, string userSplitter, string input, out string side, out string user, out bool isSideSplitter)
        {
            if (input.IndexOf(sideSpltter) != -1)
            {   //we have side | user
                var inputArr = input.Split(sideSpltter);
                side = inputArr[0];
                user = inputArr[1];
                isSideSplitter = true;
            }
            else
            {  //we have user => side 
                var inputArr = input.Split(userSplitter);
                user = inputArr[0];
                side = inputArr[1];
                isSideSplitter = false;
            }
        }

        private static void Print(Dictionary<string, List<string>> sideAndUsers)
        {
            var orderedSideAndUsers = sideAndUsers.OrderByDescending(y => y.Value.Count).ThenBy(x => x.Key);
            foreach (var side in orderedSideAndUsers)
            {
                if (side.Value.Count != 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                    var orderedListOfUsers = side.Value.OrderBy(x => x);

                    foreach (var currentUser in orderedListOfUsers)
                    {
                        Console.WriteLine($"! {currentUser}");
                    }
                }
            }
        }
    }
}