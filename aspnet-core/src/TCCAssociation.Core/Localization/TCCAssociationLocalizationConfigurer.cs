using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace TCCAssociation.Localization
{
    public static class TCCAssociationLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(TCCAssociationConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(TCCAssociationLocalizationConfigurer).GetAssembly(),
                        "TCCAssociation.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
