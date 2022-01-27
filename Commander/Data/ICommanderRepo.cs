using Commander.Model;
using System.Collections.Generic;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommand();
        Command GetCommandById(int Id);

    }
}
