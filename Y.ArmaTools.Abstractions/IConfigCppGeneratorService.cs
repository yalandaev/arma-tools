namespace Y.ArmaTools.Abstractions
{
    public interface IConfigCppGeneratorService
    {
        string GetConfigCpp(int glassCount, int doorsCount);
    }
}