using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.BaiduChannel
{
    /// <summary>
    /// AWS::Pinpoint::BaiduChannel
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
            /// The unique identifier for the application that the Baidu channel applies to.
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
