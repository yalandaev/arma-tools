namespace Y.ArmaTools.Abstractions.Services.Config
{
    public interface IConfigCppService
    {
        string GenerateHitPoints(string glassCount, float armor, float radius);
        string GetAnimationSources(int glassCount, int doorsCount);
        string GetUserActions(int doorsCount);
    }
}