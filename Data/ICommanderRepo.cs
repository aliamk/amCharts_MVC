using System.Collections.Generic;       // IEnumerable
using Commander.Models;                 // <Command>

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int Id);
    }
}