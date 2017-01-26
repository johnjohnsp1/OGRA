using System.Collections.ObjectModel;
using System.Management.Automation;

namespace ogra
{
    class ogra
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) return;
            using (PowerShell p = PowerShell.Create().AddScript(args[0]))
            {
                Collection<PSObject> Output = p.Invoke();
            }
        }
    }
}
