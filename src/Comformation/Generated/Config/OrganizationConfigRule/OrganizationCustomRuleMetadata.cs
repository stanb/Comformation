using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.OrganizationConfigRule
{
    /// <summary>
    /// AWS::Config::OrganizationConfigRule OrganizationCustomRuleMetadata
    /// An object that specifies organization custom rule metadata such as resource type, resource ID of AWS resource,
    /// Lamdba function ARN, 			and organization trigger types that trigger AWS Config to evaluate your AWS resources
    /// against a rule. 			It also provides the frequency with which you want AWS Config to run evaluations for the
    /// rule if the trigger type is periodic.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-organizationconfigrule-organizationcustomrulemetadata.html
    /// </summary>
    public class OrganizationCustomRuleMetadata
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
        /// LambdaFunctionArn
        /// 		
        /// The lambda function ARN.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaFunctionArn")]
        public Union<string, IntrinsicFunction> LambdaFunctionArn { get; set; }

        /// <summary>
        /// OrganizationConfigRuleTriggerTypes
        /// 		
        /// The type of notification that triggers AWS Config to run an evaluation for a rule. You can specify
        /// the following notification types:
        /// 		 		
        /// 			 			 		 ConfigurationItemChangeNotification - Triggers an evaluation when AWS Config delivers a
        /// configuration item as a result of a resource change. OversizedConfigurationItemChangeNotification -
        /// Triggers an evaluation when AWS Config delivers an oversized configuration item. 			 	AWS Config may
        /// generate this notification type when a resource changes and the notification exceeds the maximum
        /// size allowed by Amazon SNS. ScheduledNotification - Triggers a periodic evaluation at the frequency
        /// specified for MaximumExecutionFrequency.
        /// 	
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OrganizationConfigRuleTriggerTypes")]
        public List<Union<string, IntrinsicFunction>> OrganizationConfigRuleTriggerTypes { get; set; }

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
        /// The maximum frequency with which AWS Config runs evaluations for a rule. 			Your custom rule is
        /// triggered when AWS Config delivers the configuration snapshot. For more information, see
        /// ConfigSnapshotDeliveryProperties.
        /// 		
        /// Note By default, rules with a periodic trigger are evaluated every 24 hours. To change the
        /// frequency, specify a valid 			value for the MaximumExecutionFrequency parameter.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed Values: One_Hour | Six_Hours | Three_Hours | Twelve_Hours | TwentyFour_Hours
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
