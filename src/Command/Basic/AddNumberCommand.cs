using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Basic
{
    public class AddNumberCommand : BaseCommand
    {
        public override void Execute(string textToAdd)
        {
            Sb.Append(textToAdd);
            Entries.Add(textToAdd);
        }

        public override void UnExecute()
        {
            var entryLength = Entries[Entries.Count - 1].Length;
            var totalLength = Sb.Length;
            Sb.Remove(totalLength - entryLength, entryLength);
            Entries.RemoveAt(Entries.Count - 1);
        }
    }
}
