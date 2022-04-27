using System;

using R5T.T0064;


namespace R5T.Argumentos
{
    [ServiceDefinitionMarker]
    public interface ICommandLineArgumentsProvider : IServiceDefinition
    {
        string[] GetCommandLineArguments();
    }
}
