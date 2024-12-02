using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace InvoiceManagementSystem.Localization;

public static class InvoiceManagementSystemLocalizationConfigurer
{
    public static void Configure(ILocalizationConfiguration localizationConfiguration)
    {
        localizationConfiguration.Sources.Add(
            new DictionaryBasedLocalizationSource(InvoiceManagementSystemConsts.LocalizationSourceName,
                new XmlEmbeddedFileLocalizationDictionaryProvider(
                    typeof(InvoiceManagementSystemLocalizationConfigurer).GetAssembly(),
                    "InvoiceManagementSystem.Localization.SourceFiles"
                )
            )
        );
    }
}
