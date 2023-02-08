using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork_08._02._2023__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();
            Group group = new Group()
            {
                Name = "Metleb"
            };

            AddGroup(groups, group);

            Group group2 = new Group()
            {
                Name = "Omer"
            };

            AddGroup(groups, group2);

            Group group3 = new Group()
            {
                Name = "Metleb"
            };

            AddGroup(groups, group3);

            foreach (var groupList in groups)
            {
                Console.WriteLine(groupList.GetDetails());
            }
        }
        static void AddGroup(List<Group> groups, Group group)
        {
            var dublicateName = groups.Any(g => g.Name == group.Name);

            if (!dublicateName)
            {
                groups.Add(group);
            }
        }

        
    }
}
