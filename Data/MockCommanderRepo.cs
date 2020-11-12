using System.Collections.Generic;       // ICommanderRepo
using Commander.Models;                 // ICommanderRepo

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil and egg", Line="Boil water", Platform="Kettle & Pan"},
                new Command{Id=1, HowTo="Slice bread", Line="Get a knife", Platform="Knife & Chopping Board"},
                new Command{Id=2, HowTo="Make cup of tea", Line="Place teabad in tea", Platform="Kettle & Cup"}
            };
            return commands;
            //throw new System.NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil and egg", Line = "Boil water", Platform = "Kettle & Pan" };
            //throw new System.NotImplementedException();
        }
    }
}