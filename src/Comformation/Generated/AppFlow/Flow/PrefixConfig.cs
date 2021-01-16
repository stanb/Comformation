using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow PrefixConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-prefixconfig.html
    /// </summary>
    public class PrefixConfig
    {

        /// <summary>
        /// PrefixType
        /// Determines the level of granularity that&#39;s included in the prefix.
        /// Required: No
        /// Type: String
        /// Allowed values: FILENAME | PATH | PATH_AND_FILENAME
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrefixType")]
        public Union<string, IntrinsicFunction> PrefixType { get; set; }

        /// <summary>
        /// PrefixFormat
        /// Determines the format of the prefix, and whether it applies to the file name, file path, or both.
        /// Required: No
        /// Type: String
        /// Allowed values: DAY | HOUR | MINUTE | MONTH | YEAR
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrefixFormat")]
        public Union<string, IntrinsicFunction> PrefixFormat { get; set; }

    }
}
