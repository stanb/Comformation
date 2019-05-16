using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigRule
{
    /// <summary>
    /// AWS::Config::ConfigRule
    /// Specifies an AWS Config rule for evaluating whether your 			AWS resources comply with your desired
    /// configurations.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html
    /// </summary>
    public class ConfigRuleResource : ResourceBase
    {
        public class ConfigRuleProperties
        {
            /// <summary>
            /// ConfigRuleName
            /// A name for the AWS Config rule. If you don&#39;t specify a name, AWS CloudFormation generates a unique
            /// physical ID and uses that ID for the rule name. For more information, see Name Type.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ConfigRuleName { get; set; }

            /// <summary>
            /// Description
            /// 		
            /// The description that you provide for the AWS Config 			rule.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// InputParameters
            /// 		
            /// A string, in JSON format, that is passed to the AWS Config rule 			Lambda function.
            /// 		 	
            /// Required: No
            /// Type: Json
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> InputParameters { get; set; }

            /// <summary>
            /// MaximumExecutionFrequency
            /// 		 		
            /// The maximum frequency with which AWS Config runs evaluations 			for a rule. You can specify a value
            /// for 				MaximumExecutionFrequency when:
            /// 		
            /// 			 			 		 				 You are using an AWS managed rule that is triggered at 					a periodic frequency.
            /// 			 				 Your custom rule is triggered when AWS Config delivers 				 the configuration snapshot. For
            /// more information, see ConfigSnapshotDeliveryProperties. 			
            /// 		
            /// Note By default, rules with a periodic trigger are evaluated 				every 24 hours. To change the
            /// frequency, specify a valid value 				for the MaximumExecutionFrequency 				parameter.
            /// 		 	
            /// Required: No
            /// Type: String
            /// Allowed Values: One_Hour | Six_Hours | Three_Hours | Twelve_Hours | TwentyFour_Hours
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MaximumExecutionFrequency { get; set; }

            /// <summary>
            /// Scope
            /// 		
            /// Defines which resources can trigger an evaluation for the rule. 			The scope can include one or more
            /// resource types, a combination of 			one resource type and one resource ID, or a combination of a tag
            /// key 			and value. Specify a scope to constrain the resources that can 			trigger an evaluation for
            /// the rule. If you do not specify a scope, 			evaluations are triggered when any resource in the
            /// recording group 			changes.
            /// 	
            /// Required: No
            /// Type: Scope
            /// Update requires: No interruption
            /// </summary>
			public Scope Scope { get; set; }

            /// <summary>
            /// Source
            /// 		
            /// Provides the rule owner (AWS or customer), the rule identifier, 			and the notifications that cause
            /// the function to evaluate your AWS 			resources.
            /// 	
            /// Required: Yes
            /// Type: Source
            /// Update requires: No interruption
            /// </summary>
			public Source Source { get; set; }

        }

        public string Type { get; } = "AWS::Config::ConfigRule";

        public ConfigRuleProperties Properties { get; } = new ConfigRuleProperties();

    }

	public static class ConfigRuleAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Compliance_Type = new ResourceAttribute<Union<string, IntrinsicFunction>>("Compliance", "Type");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ConfigRuleId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ConfigRuleId");
	}
}
