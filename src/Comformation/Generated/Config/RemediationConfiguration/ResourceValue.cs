using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.RemediationConfiguration
{
    /// <summary>
    /// AWS::Config::RemediationConfiguration ResourceValue
    /// The dynamic value of the resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-remediationconfiguration-resourcevalue.html
    /// </summary>
    public class ResourceValue
    {

        /// <summary>
        /// Value
        /// 		
        /// The value is a resource ID.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed Values: RESOURCE_ID
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
