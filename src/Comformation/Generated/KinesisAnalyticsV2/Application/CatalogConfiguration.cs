using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application CatalogConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-catalogconfiguration.html
    /// </summary>
    public class CatalogConfiguration
    {

        /// <summary>
        /// GlueDataCatalogConfiguration
        /// The configuration parameters for the default Amazon Glue database. You use this database for Apache
        /// Flink SQL queries and table API transforms that you write in a Kinesis Data Analytics Studio
        /// notebook.
        /// Required: No
        /// Type: GlueDataCatalogConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GlueDataCatalogConfiguration")]
        public GlueDataCatalogConfiguration GlueDataCatalogConfiguration { get; set; }

    }
}
