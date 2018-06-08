using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigRule
{
    /// <summary>
    /// AWS::Config::ConfigRule
    /// The AWS::Config::ConfigRule resource uses an AWS Lambda (Lambda) function that evaluates configuration items
    /// to assess whether your AWS resources comply with your specified configurations. This function can run when AWS
    /// Config detects a configuration change or delivers a configuration snapshot. The resources this function
    /// evaluates must be in the recording group. For more information, see Evaluating AWS Resource Configurations
    /// with AWS Config in the AWS Config Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html
    /// </summary>
    public class ConfigRuleResource : ResourceBase
    {
        public class ConfigRuleProperties
        {
            /// <summary>
            /// ConfigRuleName
            /// A name for the AWS Config rule. If you don't specify a name, AWS CloudFormation generates a unique
            /// physical ID and uses that ID for the rule name. For more information, see Name Type.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ConfigRuleName { get; set; }

            /// <summary>
            /// Description
            /// A description about this AWS Config rule.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// InputParameters
            /// Input parameter values that are passed to the AWS Config rule (Lambda function).
            /// Required: No
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> InputParameters { get; set; }

            /// <summary>
            /// MaximumExecutionFrequency
            /// The maximum frequency at which the AWS Config rule runs evaluations. For valid values, see the
            /// ConfigRule data type in the AWS Config API Reference.
            /// If the rule runs an evaluation when AWS Config delivers a configuration snapshot, the rule cannot
            /// run more frequently than the snapshot delivery frequency. Set an execution frequency value that is
            /// equal to or greater than the value of the snapshot delivery frequency, which is a property the
            /// AWS::Config::DeliveryChannel resource.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MaximumExecutionFrequency { get; set; }

            /// <summary>
            /// Scope
            /// Defines which AWS resources will trigger an evaluation when their configurations change. The scope
            /// can include one or more resource types, a combination of a tag key and value, or a combination of
            /// one resource type and one resource ID. Specify a scope to constrain the resources that are
            /// evaluated. If you don't specify a scope, the rule evaluates all resources in the recording group.
            /// Required: No
            /// Type: AWS Config ConfigRule Scope
            /// Update requires: No interruption
            /// </summary>
			public Union<Scope, IntrinsicFunction> Scope { get; set; }

            /// <summary>
            /// Source
            /// Specifies the rule owner, the rule identifier, and the events that cause the function to evaluate
            /// your AWS resources.
            /// Required: Yes
            /// Type: AWS Config ConfigRule Source
            /// Update requires: No interruption
            /// </summary>
			public Union<Source, IntrinsicFunction> Source { get; set; }

        }
    
        public string Type { get; } = "AWS::Config::ConfigRule";
        
        public ConfigRuleProperties Properties { get; } = new ConfigRuleProperties();
    }

	public static class ConfigRuleAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
        public static readonly ResourceAttribute<string> Compliance_Type = new ResourceAttribute<string>("Compliance", "Type");
        public static readonly ResourceAttribute<string> ConfigRuleId = new ResourceAttribute<string>("ConfigRuleId");
	}
}
