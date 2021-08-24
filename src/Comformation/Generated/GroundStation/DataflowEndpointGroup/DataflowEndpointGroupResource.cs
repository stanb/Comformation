using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.DataflowEndpointGroup
{
    /// <summary>
    /// AWS::GroundStation::DataflowEndpointGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-dataflowendpointgroup.html
    /// </summary>
    public class DataflowEndpointGroupResource : ResourceBase
    {
        public class DataflowEndpointGroupProperties
        {
            /// <summary>
            /// EndpointDetails
            /// List of Endpoint Details, containing address and port for each endpoint.
            /// Required: Yes
            /// Type: List of EndpointDetails
            /// Update requires: No interruption
            /// </summary>
            public List<EndpointDetails> EndpointDetails { get; set; }

            /// <summary>
            /// Tags
            /// Tags assigned to a resource.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::GroundStation::DataflowEndpointGroup";

        public DataflowEndpointGroupProperties Properties { get; } = new DataflowEndpointGroupProperties();

    }

    public static class DataflowEndpointGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
