using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.CoreDefinition
{
    /// <summary>
    /// AWS::Greengrass::CoreDefinition Core
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-coredefinition-core.html
    /// </summary>
    public class Core
    {

        /// <summary>
        /// SyncShadow
        /// Indicates whether the core&#39;s local shadow is synced with the cloud automatically. 				 The default
        /// is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SyncShadow")]
        public Union<bool, IntrinsicFunction> SyncShadow { get; set; }

        /// <summary>
        /// ThingArn
        /// The ARN of the core, which is an AWS IoT device (thing).
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ThingArn")]
        public Union<string, IntrinsicFunction> ThingArn { get; set; }

        /// <summary>
        /// Id
        /// A descriptive or arbitrary ID for the core. This value must be unique within the core definition
        /// version. Maximum length is 128 characters with pattern [a-zA-Z0-9:_-]+.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// CertificateArn
        /// The Amazon Resource Name (ARN) of the device certificate for the core. This X. 509 certificate is
        /// used to authenticate the core with AWS IoT and AWS IoT Greengrass services.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CertificateArn")]
        public Union<string, IntrinsicFunction> CertificateArn { get; set; }

    }
}
