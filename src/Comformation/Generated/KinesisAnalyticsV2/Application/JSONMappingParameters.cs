using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application JSONMappingParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-jsonmappingparameters.html
    /// </summary>
    public class JSONMappingParameters
    {

        /// <summary>
        /// RecordRowPath
        /// The path to the top-level parent that contains the records.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 65535
        /// Pattern: ^(?=^\$)(?=^\S+$). *$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordRowPath")]
        public Union<string, IntrinsicFunction> RecordRowPath { get; set; }

    }
}
