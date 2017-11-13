namespace Wiki.Component.Tools.Language.Interfaces
{
   public interface ITranslator
    {
       string TargetLanguagePackUri { get; set; }
       string Translator(string key, string targetLanguagePackUri=null);
    }
}
