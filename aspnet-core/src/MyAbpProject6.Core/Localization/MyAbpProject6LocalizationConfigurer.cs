using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MyAbpProject6.Localization
{
    public static class MyAbpProject6LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MyAbpProject6Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MyAbpProject6LocalizationConfigurer).GetAssembly(),
                        "MyAbpProject6.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
