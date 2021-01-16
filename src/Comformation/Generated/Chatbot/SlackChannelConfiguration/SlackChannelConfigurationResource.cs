using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Chatbot.SlackChannelConfiguration
{
    /// <summary>
    /// AWS::Chatbot::SlackChannelConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chatbot-slackchannelconfiguration.html
    /// </summary>
    public class SlackChannelConfigurationResource : ResourceBase
    {
        public class SlackChannelConfigurationProperties
        {
            /// <summary>
            /// SlackWorkspaceId
            /// The ID of the Slack workspace authorized with AWS Chatbot.
            /// To get the workspace ID, you must perform the initial authorization flow with Slack in the AWS
            /// Chatbot console. Then you can copy and paste the workspace ID from the console. For more details,
            /// see steps 1-4 in Setting Up AWS Chatbot with Slack in the AWS Chatbot User Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SlackWorkspaceId { get; set; }

            /// <summary>
            /// SlackChannelId
            /// The ID of the Slack channel.
            /// To get the ID, open Slack, right click on the channel name in the left pane, then choose Copy Link.
            /// The channel ID is the 9-character string at the end of the URL. For example, ABCBBLZZZ.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SlackChannelId { get; set; }

            /// <summary>
            /// ConfigurationName
            /// The name of the configuration.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ConfigurationName { get; set; }

            /// <summary>
            /// IamRoleArn
            /// The ARN of the IAM role that defines the permissions for AWS Chatbot.
            /// This is a user-defined role that AWS Chatbot will assume. This is not the service-linked role. For
            /// more information, see IAM Policies for AWS Chatbot.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> IamRoleArn { get; set; }

            /// <summary>
            /// SnsTopicArns
            /// The ARNs of the SNS topics that deliver notifications to AWS Chatbot.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SnsTopicArns { get; set; }

            /// <summary>
            /// LoggingLevel
            /// Specifies the logging level for this configuration. This property affects the log entries pushed to
            /// Amazon CloudWatch Logs.
            /// Logging levels include ERROR, INFO, or NONE.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> LoggingLevel { get; set; }

        }

        public string Type { get; } = "AWS::Chatbot::SlackChannelConfiguration";

        public SlackChannelConfigurationProperties Properties { get; } = new SlackChannelConfigurationProperties();

    }

    public static class SlackChannelConfigurationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
