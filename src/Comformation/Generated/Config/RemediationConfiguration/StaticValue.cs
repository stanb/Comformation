using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.RemediationConfiguration
{
    /// <summary>
    /// AWS::Config::RemediationConfiguration StaticValue
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-remediationconfiguration-staticvalue.html
    /// </summary>
    public class StaticValue
    {

        /// <summary>
        /// Values
        /// 		
        /// A list of values. For example, the ARN of the assumed role.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Maximum: 25
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

    }
}
