using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.XRay.Group
{
    /// <summary>
    /// AWS::XRay::Group
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-xray-group.html
    /// </summary>
    public class GroupResource : ResourceBase
    {
        public class GroupProperties
        {
            /// <summary>
            /// FilterExpression
            /// The filter expression defining the parameters to include traces.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FilterExpression { get; set; }

            /// <summary>
            /// GroupName
            /// The unique case-sensitive name of the group.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> GroupName { get; set; }

            /// <summary>
            /// InsightsConfiguration
            /// The structure containing configurations related to insights.
            /// The InsightsEnabled boolean can be set to true to enable insights for the group or false to disable
            /// insights for the group. The NotificationsEnabled boolean can be set to true to enable insights
            /// notifications through Amazon EventBridge for the group.
            /// Required: No
            /// Type: InsightsConfiguration
            /// Update requires: No interruption
            /// </summary>
            public InsightsConfiguration InsightsConfiguration { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Json
            /// Update requires: No interruption
            /// </summary>
            public List<Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction>> Tags { get; set; }

        }

        public string Type { get; } = "AWS::XRay::Group";

        public GroupProperties Properties { get; } = new GroupProperties();

    }

    public static class GroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> GroupARN = new ResourceAttribute<Union<string, IntrinsicFunction>>("GroupARN");
    }
}
