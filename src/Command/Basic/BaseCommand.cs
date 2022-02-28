using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Basic
{
    public abstract class BaseCommand : IAppCommand
    {
        public StringBuilder Sb { get; set; }
        protected readonly List<string> Entries = new List<string>();

        public abstract void Execute(string text);

        public abstract void UnExecute();
        
    }
}
