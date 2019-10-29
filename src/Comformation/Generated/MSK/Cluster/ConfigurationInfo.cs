using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MSK.Cluster
{
    /// <summary>
    /// AWS::MSK::Cluster ConfigurationInfo
    /// Specifies the Amazon MSK configuration to use for the brokers.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-configurationinfo.html
    /// </summary>
    public class ConfigurationInfo
    {

        /// <summary>
        /// Revision
        /// The revision of the Amazon MSK configuration to use.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Revision")]
        public Union<int, IntrinsicFunction> Revision { get; set; }

        /// <summary>
        /// Arn
        /// The Amazon Resource Name (ARN) of the MSK configuration to use. For example,
        /// arn:aws:kafka:us-east-1:123456789012:configuration/example-configuration-name/abcdabcd-1234-abcd-1234-abcd123e8e8e-1.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

    }
}
