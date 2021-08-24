using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application GlueDataCatalogConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-gluedatacatalogconfiguration.html
    /// </summary>
    public class GlueDataCatalogConfiguration
    {

        /// <summary>
        /// DatabaseARN
        /// The Amazon Resource Name (ARN) of the database.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: arn:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseARN")]
        public Union<string, IntrinsicFunction> DatabaseARN { get; set; }

    }
}
