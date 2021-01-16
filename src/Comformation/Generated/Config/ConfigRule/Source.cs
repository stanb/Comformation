using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigRule
{
    /// <summary>
    /// AWS::Config::ConfigRule Source
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-source.html
    /// </summary>
    public class Source
    {

        /// <summary>
        /// Owner
        /// 		
        /// Indicates whether AWS or the customer owns and manages the AWS 			Config rule.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: AWS | CUSTOM_LAMBDA
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Owner")]
        public Union<string, IntrinsicFunction> Owner { get; set; }

        /// <summary>
        /// SourceDetails
        /// 		
        /// Provides the source and type of the event that causes AWS 			Config to evaluate your AWS resources.
        /// 	
        /// Required: No
        /// Type: List of SourceDetail
        /// Maximum: 25
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceDetails")]
        public List<SourceDetail> SourceDetails { get; set; }

        /// <summary>
        /// SourceIdentifier
        /// 		
        /// For AWS Config managed rules, a predefined identifier from a 			list. For example,
        /// IAM_PASSWORD_POLICY is a managed 			rule. To reference a managed rule, see Using AWS Managed Config
        /// Rules.
        /// 		
        /// For custom rules, the identifier is the Amazon Resource Name 			(ARN) of the rule&#39;s AWS Lambda
        /// function, such as 				arn:aws:lambda:us-east-2:123456789012:function:custom_rule_name.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceIdentifier")]
        public Union<string, IntrinsicFunction> SourceIdentifier { get; set; }

    }
}
