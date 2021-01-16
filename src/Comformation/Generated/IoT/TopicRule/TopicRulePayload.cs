using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule TopicRulePayload
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-topicrulepayload.html
    /// </summary>
    public class TopicRulePayload
    {

        /// <summary>
        /// Actions
        /// The actions associated with the rule.
        /// Required: Yes
        /// Type: List of Action
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Actions")]
        public List<Action> Actions { get; set; }

        /// <summary>
        /// AwsIotSqlVersion
        /// The version of the SQL rules engine to use when evaluating the rule.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsIotSqlVersion")]
        public Union<string, IntrinsicFunction> AwsIotSqlVersion { get; set; }

        /// <summary>
        /// Description
        /// The description of the rule.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// ErrorAction
        /// The action to take when an error occurs.
        /// Required: No
        /// Type: Action
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ErrorAction")]
        public Action ErrorAction { get; set; }

        /// <summary>
        /// RuleDisabled
        /// Specifies whether the rule is disabled.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuleDisabled")]
        public Union<bool, IntrinsicFunction> RuleDisabled { get; set; }

        /// <summary>
        /// Sql
        /// The SQL statement used to query the topic. For more information, see AWS IoT SQL Reference in the
        /// AWS IoT Developer Guide.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Sql")]
        public Union<string, IntrinsicFunction> Sql { get; set; }

    }
}
