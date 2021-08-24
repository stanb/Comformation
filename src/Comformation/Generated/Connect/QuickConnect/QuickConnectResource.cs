using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Connect.QuickConnect
{
    /// <summary>
    /// AWS::Connect::QuickConnect
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-quickconnect.html
    /// </summary>
    public class QuickConnectResource : ResourceBase
    {
        public class QuickConnectProperties
        {
            /// <summary>
            /// InstanceArn
            /// The Amazon Resource Name (ARN) of the instance.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> InstanceArn { get; set; }

            /// <summary>
            /// Name
            /// The name of the quick connect.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 127
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// The description of the quick connect.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 250
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// QuickConnectConfig
            /// Contains information about the quick connect.
            /// Required: Yes
            /// Type: QuickConnectConfig
            /// Update requires: No interruption
            /// </summary>
            public QuickConnectConfig QuickConnectConfig { get; set; }

            /// <summary>
            /// Tags
            /// One or more tags.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Connect::QuickConnect";

        public QuickConnectProperties Properties { get; } = new QuickConnectProperties();

    }

    public static class QuickConnectAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> QuickConnectArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("QuickConnectArn");
    }
}
