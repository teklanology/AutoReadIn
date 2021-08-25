using Tekla.Structures.Model.Operations;

namespace Tekla.Technology.Akit.UserScript
{
    static class Script
    {
        public static void Run(Tekla.Technology.Akit.IScript akit)
        {
            Operation.RunMacro("ReadIn.cs");
        }
    }
}
