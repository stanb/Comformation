using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaStore.Container
{
    /// <summary>
    /// AWS::MediaStore::Container
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediastore-container.html
    /// </summary>
    public class ContainerResource : ResourceBase
    {
        public class ContainerProperties
        {
            /// <summary>
            /// Policy
            /// Creates an access policy for the specified container to restrict the users and clients that can
            /// access it. For information about the data that is included in an access policy, see the AWS Identity
            /// and Access Management User Guide.
            /// For this release of the REST API, you can create only one policy for a container. If you enter
            /// PutContainerPolicy twice, the second command modifies the existing policy.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Policy { get; set; }

            /// <summary>
            /// MetricPolicy
            /// The metric policy that is associated with the container. A metric policy allows AWS Elemental
            /// MediaStore to send metrics to Amazon CloudWatch. In the policy, you must indicate whether you want
            /// MediaStore to send container-level metrics. You can also include rules to define groups of objects
            /// that you want MediaStore to send object-level metrics for.
            /// To view examples of how to construct a metric policy for your use case, see Example Metric Policies.
            /// Required: No
            /// Type: MetricPolicy
            /// Update requires: No interruption
            /// </summary>
            public MetricPolicy MetricPolicy { get; set; }

            /// <summary>
            /// ContainerName
            /// The name for the container. The name must be from 1 to 255 characters. Container names must be
            /// unique to your AWS account within a specific region. As an example, you could create a container
            /// named movies in every region, as long as you don’t have an existing container with that name.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: [\w-]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ContainerName { get; set; }

            /// <summary>
            /// CorsPolicy
            /// Sets the cross-origin resource sharing (CORS) configuration on a container so that the container can
            /// service cross-origin requests. For example, you might want to enable a request whose origin is
            /// http://www. example. com to access your AWS Elemental MediaStore container at my. example.
            /// container. com by using the browser&#39;s XMLHttpRequest capability.
            /// To enable CORS on a container, you attach a CORS policy to the container. In the CORS policy, you
            /// configure rules that identify origins and the HTTP methods that can be executed on your container.
            /// The policy can contain up to 398,000 characters. You can add up to 100 rules to a CORS policy. If
            /// more than one rule applies, the service uses the first applicable rule listed.
            /// To learn more about CORS, see Cross-Origin Resource Sharing (CORS) in AWS Elemental MediaStore.
            /// Required: No
            /// Type: List of CorsRule
            /// Update requires: No interruption
            /// </summary>
            public List<CorsRule> CorsPolicy { get; set; }

            /// <summary>
            /// LifecyclePolicy
            /// Writes an object lifecycle policy to a container. If the container already has an object lifecycle
            /// policy, the service replaces the existing policy with the new policy. It takes up to 20 minutes for
            /// the change to take effect.
            /// For information about how to construct an object lifecycle policy, see Components of an Object
            /// Lifecycle Policy.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> LifecyclePolicy { get; set; }

            /// <summary>
            /// AccessLoggingEnabled
            /// The state of access logging on the container. This value is false by default, indicating that AWS
            /// Elemental MediaStore does not send access logs to Amazon CloudWatch Logs. When you enable access
            /// logging on the container, MediaStore changes this value to true, indicating that the service
            /// delivers access logs for objects stored in that container to CloudWatch Logs.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AccessLoggingEnabled { get; set; }

            /// <summary>
            /// Tags
            /// A collection of tags associated with a container. Each tag consists of a key:value pair, which can
            /// be anything you define. Typically, the tag key represents a category (such as &quot;environment&quot;) and the
            /// tag value represents a specific value within that category (such as &quot;test,&quot; &quot;development,&quot; or
            /// &quot;production&quot;). You can add up to 50 tags to each container. For more information about tagging,
            /// including naming and usage conventions, see Tagging Resources in MediaStore.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::MediaStore::Container";

        public ContainerProperties Properties { get; } = new ContainerProperties();

    }

    public static class ContainerAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Endpoint = new ResourceAttribute<Union<string, IntrinsicFunction>>("Endpoint");
    }
}
