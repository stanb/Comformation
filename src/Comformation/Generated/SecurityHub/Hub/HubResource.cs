using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SecurityHub.Hub
{
    /// <summary>
    /// AWS::SecurityHub::Hub
    /// The AWS::SecurityHub::Hub resource represents the implementation of the AWS Security Hub service in your
    /// account. One hub resource is created for each Region in which you enable Security Hub.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-hub.html
    /// </summary>
    public class HubResource : ResourceBase
    {
        public class HubProperties
        {
            /// <summary>
            /// Tags
            /// The tags to add to the hub resource.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

        }

        public string Type { get; } = "AWS::SecurityHub::Hub";

        public HubProperties Properties { get; } = new HubProperties();

    }
}
