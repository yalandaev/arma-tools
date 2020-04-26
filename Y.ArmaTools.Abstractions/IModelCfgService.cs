namespace Y.ArmaTools.Abstractions
{
    public interface IModelCfgService
    {
        string GetSkeletonBones(int glassCount, int doorsCount);
        string GetGlassSections(int glassCount);
        string GetAnimations(int glassCount, int doorsCount);
    }
}