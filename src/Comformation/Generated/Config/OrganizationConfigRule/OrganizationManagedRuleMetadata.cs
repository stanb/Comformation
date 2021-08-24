using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.OrganizationConfigRule
{
    /// <summary>
    /// AWS::Config::OrganizationConfigRule OrganizationManagedRuleMetadata
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-organizationconfigrule-organizationmanagedrulemetadata.html
    /// </summary>
    public class OrganizationManagedRuleMetadata
    {

        /// <summary>
        /// TagKeyScope
        /// 		
        /// One part of a key-value pair that make up a tag. 			A key is a general label that acts like a
        /// category for more specific tag values.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagKeyScope")]
        public Union<string, IntrinsicFunction> TagKeyScope { get; set; }

        /// <summary>
        /// TagValueScope
        /// 		
        /// The optional part of a key-value pair that make up a tag. 			A value acts as a descriptor within a
        /// tag category (key).
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagValueScope")]
        public Union<string, IntrinsicFunction> TagValueScope { get; set; }

        /// <summary>
        /// Description
        /// 		
        /// The description that you provide for organization config rule.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// ResourceIdScope
        /// 		
        /// The ID of the AWS resource that was evaluated.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 768
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceIdScope")]
        public Union<string, IntrinsicFunction> ResourceIdScope { get; set; }

        /// <summary>
        /// RuleIdentifier
        /// 		
        /// For organization config managed rules, a predefined identifier from a 			list. For example,
        /// IAM_PASSWORD_POLICY is a managed 			rule. To reference a managed rule, see Using AWS Config managed
        /// rules.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuleIdentifier")]
        public Union<string, IntrinsicFunction> RuleIdentifier { get; set; }

        /// <summary>
        /// ResourceTypesScope
        /// 		
        /// The type of the AWS resource that was evaluated.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceTypesScope")]
        public List<Union<string, IntrinsicFunction>> ResourceTypesScope { get; set; }

        /// <summary>
        /// MaximumExecutionFrequency
        /// 		
        /// The maximum frequency with which AWS Config runs evaluations for a rule. You are using an AWS Config
        /// managed rule that is triggered at a periodic frequency.
        /// 		
        /// Note By default, rules with a periodic trigger are evaluated every 24 hours. To change the
        /// frequency, specify a valid 			value for the MaximumExecutionFrequency parameter.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: One_Hour | Six_Hours | Three_Hours | Twelve_Hours | TwentyFour_Hours
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaximumExecutionFrequency")]
        public Union<string, IntrinsicFunction> MaximumExecutionFrequency { get; set; }

        /// <summary>
        /// InputParameters
        /// 		
        /// A string, in JSON format, that is passed to organization config rule Lambda function.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputParameters")]
        public Union<string, IntrinsicFunction> InputParameters { get; set; }

    }
}
