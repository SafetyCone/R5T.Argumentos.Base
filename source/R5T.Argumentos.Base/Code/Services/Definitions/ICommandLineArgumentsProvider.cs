using System;


namespace R5T.Argumentos
{
    public interface ICommandLineArgumentsProvider
    {
        string[] GetCommandLineArguments();
    }
}
