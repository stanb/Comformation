using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRuleDestination
{
    /// <summary>
    /// AWS::IoT::TopicRuleDestination
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-topicruledestination.html
    /// </summary>
    public class TopicRuleDestinationResource : ResourceBase
    {
        public class TopicRuleDestinationProperties
        {
            /// <summary>
            /// Status
            /// IN_PROGRESS A topic rule destination was created but has not been confirmed. You can set status to
            /// IN_PROGRESS by calling UpdateTopicRuleDestination. Calling UpdateTopicRuleDestination causes a new
            /// confirmation challenge to be sent to your confirmation endpoint. ENABLED Confirmation was completed,
            /// and traffic to this destination is allowed. You can set status to DISABLED by calling
            /// UpdateTopicRuleDestination. DISABLED Confirmation was completed, and traffic to this destination is
            /// not allowed. You can set status to ENABLED by calling UpdateTopicRuleDestination. ERROR Confirmation
            /// could not be completed; for example, if the confirmation timed out. You can call
            /// GetTopicRuleDestination for details about the error. You can set status to IN_PROGRESS by calling
            /// UpdateTopicRuleDestination. Calling UpdateTopicRuleDestination causes a new confirmation challenge
            /// to be sent to your confirmation endpoint.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Status { get; set; }

            /// <summary>
            /// HttpUrlProperties
            /// Properties of the HTTP URL.
            /// Required: No
            /// Type: HttpUrlDestinationSummary
            /// Update requires: Replacement
            /// </summary>
            public HttpUrlDestinationSummary HttpUrlProperties { get; set; }

            /// <summary>
            /// VpcProperties
            /// Properties of the virtual private cloud (VPC) connection.
            /// Required: No
            /// Type: VpcDestinationProperties
            /// Update requires: Replacement
            /// </summary>
            public VpcDestinationProperties VpcProperties { get; set; }

        }

        public string Type { get; } = "AWS::IoT::TopicRuleDestination";

        public TopicRuleDestinationProperties Properties { get; } = new TopicRuleDestinationProperties();

    }

    public static class TopicRuleDestinationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StatusReason = new ResourceAttribute<Union<string, IntrinsicFunction>>("StatusReason");
    }
}
