namespace Y.ArmaTools.Abstractions
{
    public interface IConfigCppService
    {
        string GenerateHitPoints(string glassCount, float armor, float radius);
        string GetAnimationSources(int glassCount, int doorsCount);
        string GetUserActions(int doorsCount);
    }
}