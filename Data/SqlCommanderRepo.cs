using System.Collections.Generic;       // ICommanderRepo
using System.Linq;                      // ToList
using Commander.Models;                 // ICommanderRepo

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
            //throw new System.NotImplementedException();
        }


        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
            //throw new System.NotImplementedException();
        }
    }
}