using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MPAPhoneProject.Localization
{
    public static class MPAPhoneProjectLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MPAPhoneProjectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MPAPhoneProjectLocalizationConfigurer).GetAssembly(),
                        "MPAPhoneProject.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
