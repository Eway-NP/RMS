using System.Linq;
using System.Xml.Linq;
using Wiki.Component.Tools.Language.Interfaces;

namespace Wiki.Component.Tools.Language.Implements
{
    public class LanguageTranslator : ITranslator
    {
        private static string _targetLanguagePackUri;
        public string TargetLanguagePackUri
        {
            get
            {
                return _targetLanguagePackUri;
            }
            set
            {
                _targetLanguagePackUri = value;
            }

        }

        public string Translator(string key, string targetLanguagePackUri = null)
        {
            XDocument doc = null;
            if (!string.IsNullOrWhiteSpace(targetLanguagePackUri))
            {
                doc = XDocument.Load(targetLanguagePackUri);
            }
            else
            {
                doc = XDocument.Load(_targetLanguagePackUri);
            }
            var elements = doc.Root.Elements("Lang");
            var xElements = elements as XElement[] ?? elements.ToArray();
            if (xElements.Any())
            {
                // ReSharper disable once PossibleNullReferenceException
                var node = xElements.FirstOrDefault(d => d.Attribute("key") != null && d.Attribute("key").Value == key);
                if (node != null)
                    if (node.Attribute("value") != null)
                        // ReSharper disable once PossibleNullReferenceException
                        return node.Attribute("value").Value;
            }

            return null;
        }
    }
}
