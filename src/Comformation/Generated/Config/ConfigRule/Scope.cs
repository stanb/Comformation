using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigRule
{
    /// <summary>
    /// AWS::Config::ConfigRule Scope
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-scope.html
    /// </summary>
    public class Scope
    {

        /// <summary>
        /// ComplianceResourceId
        /// 		
        /// The ID of the only AWS resource that you want to trigger an 			evaluation for the rule. If you
        /// specify a resource ID, you must 			specify one resource type for 			ComplianceResourceTypes.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 768
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComplianceResourceId")]
        public Union<string, IntrinsicFunction> ComplianceResourceId { get; set; }

        /// <summary>
        /// ComplianceResourceTypes
        /// 		
        /// The resource types of only those AWS resources that you want to 			trigger an evaluation for the
        /// rule. You can only specify one type if 			you also specify a resource ID for
        /// 			ComplianceResourceId.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComplianceResourceTypes")]
        public List<Union<string, IntrinsicFunction>> ComplianceResourceTypes { get; set; }

        /// <summary>
        /// TagKey
        /// 		
        /// The tag key that is applied to only those AWS resources that 			you want to trigger an evaluation
        /// for the rule.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagKey")]
        public Union<string, IntrinsicFunction> TagKey { get; set; }

        /// <summary>
        /// TagValue
        /// 		
        /// The tag value applied to only those AWS resources that you want 			to trigger an evaluation for the
        /// rule. If you specify a value for 				TagValue, you must also specify a value for 				TagKey.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagValue")]
        public Union<string, IntrinsicFunction> TagValue { get; set; }

    }
}
