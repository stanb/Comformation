using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.DataCatalogEncryptionSettings
{
    /// <summary>
    /// AWS::Glue::DataCatalogEncryptionSettings
    /// Sets the security configuration for a specified catalog. After the configuration has been set, the specified
    /// encryption is applied to every catalog write thereafter.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-datacatalogencryptionsettings.html
    /// </summary>
    public class DataCatalogEncryptionSettingsResource : ResourceBase
    {
        public class DataCatalogEncryptionSettingsProperties
        {
            /// <summary>
            /// DataCatalogEncryptionSettings
            /// Contains configuration information for maintaining Data Catalog security.
            /// Required: Yes
            /// Type: DataCatalogEncryptionSettings
            /// Update requires: No interruption
            /// </summary>
			public DataCatalogEncryptionSettings DataCatalogEncryptionSettings { get; set; }

            /// <summary>
            /// CatalogId
            /// The ID of the Data Catalog in which the settings are created.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CatalogId { get; set; }

        }

        public string Type { get; } = "AWS::Glue::DataCatalogEncryptionSettings";

        public DataCatalogEncryptionSettingsProperties Properties { get; } = new DataCatalogEncryptionSettingsProperties();

    }
}
