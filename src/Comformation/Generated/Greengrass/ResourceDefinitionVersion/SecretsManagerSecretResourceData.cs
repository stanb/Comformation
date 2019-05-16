using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.ResourceDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::ResourceDefinitionVersion SecretsManagerSecretResourceData
    /// Settings for a secret resource, 		which references a secret from AWS Secrets Manager. AWS IoT Greengrass
    /// stores a local, encrypted copy of the secret on the Greengrass core, 		where it can be securely accessed by
    /// connectors and Lambda functions. 		For more information, see Deploy Secrets to the AWS IoT Greengrass Core in
    /// the AWS IoT Greengrass Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-secretsmanagersecretresourcedata.html
    /// </summary>
    public class SecretsManagerSecretResourceData
    {

        /// <summary>
        /// ARN
        /// The Amazon Resource Name (ARN) of the Secrets Manager secret to make available on the core. The
        /// value of the secret&#39;s 				 latest version (represented by the AWSCURRENT staging label) is included
        /// by default.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ARN")]
        public Union<string, IntrinsicFunction> ARN { get; set; }

        /// <summary>
        /// AdditionalStagingLabelsToDownload
        /// The staging labels whose values you want to make available on the core, in addition to AWSCURRENT.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AdditionalStagingLabelsToDownload")]
        public List<Union<string, IntrinsicFunction>> AdditionalStagingLabelsToDownload { get; set; }

    }
}
