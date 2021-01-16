using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.OrganizationConformancePack
{
    /// <summary>
    /// AWS::Config::OrganizationConformancePack ConformancePackInputParameter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-organizationconformancepack-conformancepackinputparameter.html
    /// </summary>
    public class ConformancePackInputParameter
    {

        /// <summary>
        /// ParameterName
        /// 		
        /// One part of a key-value pair.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParameterName")]
        public Union<string, IntrinsicFunction> ParameterName { get; set; }

        /// <summary>
        /// ParameterValue
        /// 		
        /// One part of a key-value pair.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParameterValue")]
        public Union<string, IntrinsicFunction> ParameterValue { get; set; }

    }
}
