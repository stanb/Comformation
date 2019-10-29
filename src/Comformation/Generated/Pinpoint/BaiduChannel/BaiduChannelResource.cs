using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.BaiduChannel
{
    /// <summary>
    /// AWS::Pinpoint::BaiduChannel
    /// A channel is a type of platform that you can deliver messages to. You can use the Baidu channel to send
    /// notifications to the Baidu notification service. Before you use Amazon Pinpoint to send notifications to
    /// Baidu, you have to enable the Baidu channel for an Amazon Pinpoint app.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-baiduchannel.html
    /// </summary>
    public class BaiduChannelResource : ResourceBase
    {
        public class BaiduChannelProperties
        {
            /// <summary>
            /// SecretKey
            /// The secret key that you received from the Baidu Cloud Push service to communicate with the service.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SecretKey { get; set; }

            /// <summary>
            /// ApiKey
            /// The API key that you received from the Baidu Cloud Push service to communicate with the service.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ApiKey { get; set; }

            /// <summary>
            /// Enabled
            /// Specifies whether to enable the Baidu channel for the application.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// ApplicationId
            /// The unique ID of the Amazon Pinpoint app that you&#39;re configuring the Baidu channel for.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationId { get; set; }

        }

        public string Type { get; } = "AWS::Pinpoint::BaiduChannel";

        public BaiduChannelProperties Properties { get; } = new BaiduChannelProperties();

    }
}
