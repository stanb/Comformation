using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.RemediationConfiguration
{
    /// <summary>
    /// AWS::Config::RemediationConfiguration RemediationParameterValue
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-remediationconfiguration-remediationparametervalue.html
    /// </summary>
    public class RemediationParameterValue
    {

        /// <summary>
        /// ResourceValue
        /// 		
        /// The value is dynamic and changes at run-time.
        /// 	
        /// Required: No
        /// Type: ResourceValue
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceValue")]
        public ResourceValue ResourceValue { get; set; }

        /// <summary>
        /// StaticValue
        /// 		
        /// The value is static and does not change at run-time.
        /// 	
        /// Required: No
        /// Type: StaticValue
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StaticValue")]
        public StaticValue StaticValue { get; set; }

    }
}
