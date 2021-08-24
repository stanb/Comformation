using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NimbleStudio.Studio
{
    /// <summary>
    /// AWS::NimbleStudio::Studio StudioEncryptionConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-nimblestudio-studio-studioencryptionconfiguration.html
    /// </summary>
    public class StudioEncryptionConfiguration
    {

        /// <summary>
        /// KeyArn
        /// The ARN for a KMS key that is used to encrypt studio data.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyArn")]
        public Union<string, IntrinsicFunction> KeyArn { get; set; }

        /// <summary>
        /// KeyType
        /// The type of KMS key that is used to encrypt studio data.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyType")]
        public Union<string, IntrinsicFunction> KeyType { get; set; }

    }
}
