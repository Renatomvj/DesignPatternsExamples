using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Basic
{
    public class Controller
    {
        public IAppCommand GetCommandReference(IAppCommand command)
        {
            return command;
        }
    }
}
