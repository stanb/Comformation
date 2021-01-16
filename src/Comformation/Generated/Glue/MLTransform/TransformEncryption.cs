using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.MLTransform
{
    /// <summary>
    /// AWS::Glue::MLTransform TransformEncryption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-transformencryption.html
    /// </summary>
    public class TransformEncryption
    {

        /// <summary>
        /// MLUserDataEncryption
        /// An MLUserDataEncryption object containing the encryption mode and customer-provided KMS key ID.
        /// Required: No
        /// Type: MLUserDataEncryption
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MLUserDataEncryption")]
        public MLUserDataEncryption MLUserDataEncryption { get; set; }

        /// <summary>
        /// TaskRunSecurityConfigurationName
        /// The name of the security configuration.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TaskRunSecurityConfigurationName")]
        public Union<string, IntrinsicFunction> TaskRunSecurityConfigurationName { get; set; }

    }
}
