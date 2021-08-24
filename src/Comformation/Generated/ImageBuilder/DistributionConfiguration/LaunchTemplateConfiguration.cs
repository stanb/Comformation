using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.DistributionConfiguration
{
    /// <summary>
    /// AWS::ImageBuilder::DistributionConfiguration LaunchTemplateConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-launchtemplateconfiguration.html
    /// </summary>
    public class LaunchTemplateConfiguration
    {

        /// <summary>
        /// LaunchTemplateId
        /// 		
        /// Identifies the Amazon EC2 launch template to use.
        /// 	
        /// Required: No
        /// Type: String
        /// Pattern: ^lt-[a-z0-9-_]{17}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchTemplateId")]
        public Union<string, IntrinsicFunction> LaunchTemplateId { get; set; }

        /// <summary>
        /// AccountId
        /// 		
        /// The account ID that this configuration applies to.
        /// 	
        /// Required: No
        /// Type: String
        /// Pattern: ^[0-9]{12}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccountId")]
        public Union<string, IntrinsicFunction> AccountId { get; set; }

        /// <summary>
        /// SetDefaultVersion
        /// 		
        /// Set the specified Amazon EC2 launch template as the default launch template for the specified
        /// account.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SetDefaultVersion")]
        public Union<bool, IntrinsicFunction> SetDefaultVersion { get; set; }

    }
}
