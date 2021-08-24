using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppRunner.Service
{
    /// <summary>
    /// AWS::AppRunner::Service EncryptionConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-encryptionconfiguration.html
    /// </summary>
    public class EncryptionConfiguration
    {

        /// <summary>
        /// KmsKey
        /// The ARN of the KMS key that&#39;s used for encryption.
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Pattern:
        /// arn:aws(-[\w]+)*:kms:[a-z\-]+-[0-9]{1}:[0-9]{12}:key\/[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("KmsKey")]
        public Union<string, IntrinsicFunction> KmsKey { get; set; }

    }
}
