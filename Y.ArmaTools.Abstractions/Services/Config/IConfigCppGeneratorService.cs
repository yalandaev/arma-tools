namespace Y.ArmaTools.Abstractions.Services.Config
{
    public interface IConfigCppGeneratorService
    {
        string GetConfigCpp(int glassCount, int doorsCount);
    }
}