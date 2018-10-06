using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigRule
{
    /// <summary>
    /// AWS Config ConfigRule Scope
    /// Scope is a property of the AWS::Config::ConfigRule resource that specifies which AWS resources will trigger
    /// AWS Config to run an evaluation when their configurations change. The scope can include one or more resource
    /// types, a tag key and value, or one resource type and one resource ID. You cannot specify a tag-key value and a
    /// resource ID or type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-scope.html
    /// </summary>
    public class Scope
    {

        /// <summary>
        /// ComplianceResourceId
        /// The ID of an AWS resource that you want AWS Config to evaluate against a rule. If you specify an ID,
        /// you must also specify a resource type for the ComplianceResourceTypes property.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("ComplianceResourceId")]
        public Union<string, IntrinsicFunction> ComplianceResourceId { get; set; }

        /// <summary>
        /// ComplianceResourceTypes
        /// The types of AWS resources that you want AWS Config to evaluate against the rule. If you specify the
        /// ComplianceResourceId property, specify only one resource type. For more information, see Supported
        /// Resources, Configuration Items, and Relationships.
        /// Required: Conditional. If you specify a value for the ComplianceResourceId property, you must also
        /// specify this property.
        /// Type: List of String values
        /// </summary>
        [JsonProperty("ComplianceResourceTypes")]
        public List<Union<string, IntrinsicFunction>> ComplianceResourceTypes { get; set; }

        /// <summary>
        /// TagKey
        /// The tag key that is applied to the AWS resources that you want AWS Config to evaluate against the
        /// rule.
        /// Required: Conditional. If you specify a tag value, you must specify this property.
        /// Type: String
        /// </summary>
        [JsonProperty("TagKey")]
        public Union<string, IntrinsicFunction> TagKey { get; set; }

        /// <summary>
        /// TagValue
        /// The tag value that is applied to the AWS resources that you want AWS Config to evaluate against the
        /// rule.
        /// Required: Conditional. If you specify a tag key, you must specify this property.
        /// Type: String
        /// </summary>
        [JsonProperty("TagValue")]
        public Union<string, IntrinsicFunction> TagValue { get; set; }

    }
}
