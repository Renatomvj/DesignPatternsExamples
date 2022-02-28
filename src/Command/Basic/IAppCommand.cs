using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Basic
{
    public interface IAppCommand
    {
        StringBuilder Sb { get; set; }
        void Execute(string text);
        void UnExecute();
    }
}
