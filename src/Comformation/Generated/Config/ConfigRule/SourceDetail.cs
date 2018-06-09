using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigRule
{
    /// <summary>
    /// AWS Config ConfigRule SourceDetails
    /// SourceDetails is a property of the AWS Config ConfigRule Source property that specifies the source and type of
    /// event that triggers AWS Config to evaluate your AWS resources.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configrule-source-sourcedetails.html
    /// </summary>
    public class SourceDetail
    {

        /// <summary>
        /// EventSource
        /// The source, such as an AWS service, that generate events, triggering AWS Config to evaluate your AWS
        /// resources.
        /// Valid Values: aws. config
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("EventSource")]
        public Union<string, IntrinsicFunction> EventSource { get; set; }

        /// <summary>
        /// MaximumExecutionFrequency
        /// The frequency that you want AWS Config to run evaluations for a custom rule with a periodic trigger.
        /// By default, rules with a periodic trigger are evaluated every 24 hours. If you specify a value for
        /// MaximumExecutionFrequency, then MessageType must use the ScheduledNotification value.
        /// Valid values: One_Hour, Three_Hours, Six_Hours, Twelve_Hours, or TwentyFour_Hours.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("MaximumExecutionFrequency")]
        public Union<string, IntrinsicFunction> MaximumExecutionFrequency { get; set; }

        /// <summary>
        /// MessageType
        /// The type of Amazon Simple Notification Service (Amazon SNS) message that triggers AWS Config to run
        /// an evaluation. For more information, see the SourceDetail data type in the AWS Config API Reference.
        /// Valid Values: ConfigurationItemChangeNotification, ConfigurationSnapshotDeliveryCompleted,
        /// ScheduledNotification, OversizedConfigurationItemChangeNotification
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("MessageType")]
        public Union<string, IntrinsicFunction> MessageType { get; set; }

    }
}
