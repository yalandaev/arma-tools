namespace Y.ArmaTools.Abstractions.Services.Config
{
    public interface ITextToolsService
    {
        string GenerateIncrementStringsByTemplate(string template, int startIndex, int endIndex);
    }
}