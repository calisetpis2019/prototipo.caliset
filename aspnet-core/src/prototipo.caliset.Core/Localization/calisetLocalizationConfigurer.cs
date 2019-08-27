using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace prototipo.caliset.Localization
{
    public static class calisetLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(calisetConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(calisetLocalizationConfigurer).GetAssembly(),
                        "prototipo.caliset.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
