namespace Y.ArmaTools.Abstractions
{
    public interface ITextToolsService
    {
        string GenerateIncrementStringsByTemplate(string template, int startIndex, int endIndex);
    }
}