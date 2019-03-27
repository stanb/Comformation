using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Endpoint
{
    /// <summary>
    /// AWS::SageMaker::Endpoint
    /// Use the AWS::SageMaker::Endpoint resource to create an endpoint using the specified configuration in the
    /// request. Amazon SageMaker uses the endpoint to provision resources and deploy models. You create the endpoint
    /// configuration with the AWS::SageMaker::EndpointConfig resource. For more information, see Deploying a Model on
    /// Amazon SageMaker Hosting Services in the SageMaker Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html
    /// </summary>
    public class EndpointResource : ResourceBase
    {
        public class EndpointProperties
        {
            /// <summary>
            /// EndpointName
            /// The name of the endpoint.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EndpointName { get; set; }

            /// <summary>
            /// EndpointConfigName
            /// The name of the AWS::SageMaker::EndpointConfig resource that specifies the configuration for the
            /// endpoint.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EndpointConfigName { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs. For more information, see Using Cost Allocation Tags in the AWS Billing
            /// and Cost Management User Guide.
            /// Required: No
            /// Type: List of Resource Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::Endpoint";

        public EndpointProperties Properties { get; } = new EndpointProperties();

    }

	public static class EndpointAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> EndpointName = new ResourceAttribute<Union<string, IntrinsicFunction>>("EndpointName");
	}
}
