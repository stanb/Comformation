using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppRunner.Service
{
    /// <summary>
    /// AWS::AppRunner::Service
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-service.html
    /// </summary>
    public class ServiceResource : ResourceBase
    {
        public class ServiceProperties
        {
            /// <summary>
            /// ServiceName
            /// A name for the new service. It must be unique across all the running App Runner services in your AWS
            /// account in the AWS Region.
            /// Required: No
            /// Type: String
            /// Minimum: 4
            /// Maximum: 40
            /// Pattern: [A-Za-z0-9][A-Za-z0-9-_]{3,39}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ServiceName { get; set; }

            /// <summary>
            /// SourceConfiguration
            /// The source to deploy to the App Runner service. It can be a code or an image repository.
            /// Required: Yes
            /// Type: SourceConfiguration
            /// Update requires: No interruption
            /// </summary>
            public SourceConfiguration SourceConfiguration { get; set; }

            /// <summary>
            /// InstanceConfiguration
            /// The runtime configuration of instances (scaling units) of the App Runner service.
            /// Required: No
            /// Type: InstanceConfiguration
            /// Update requires: No interruption
            /// </summary>
            public InstanceConfiguration InstanceConfiguration { get; set; }

            /// <summary>
            /// Tags
            /// An optional list of metadata items that you can associate with your service resource. A tag is a
            /// key-value pair.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// EncryptionConfiguration
            /// An optional custom encryption key that App Runner uses to encrypt the copy of your source repository
            /// that it maintains and your service logs. By default, App Runner uses an AWS managed CMK.
            /// Required: No
            /// Type: EncryptionConfiguration
            /// Update requires: Replacement
            /// </summary>
            public EncryptionConfiguration EncryptionConfiguration { get; set; }

            /// <summary>
            /// HealthCheckConfiguration
            /// The settings for the health check that AWS App Runner performs to monitor the health of your
            /// service.
            /// Required: No
            /// Type: HealthCheckConfiguration
            /// Update requires: No interruption
            /// </summary>
            public HealthCheckConfiguration HealthCheckConfiguration { get; set; }

            /// <summary>
            /// AutoScalingConfigurationArn
            /// The Amazon Resource Name (ARN) of an App Runner automatic scaling configuration resource that you
            /// want to associate with your service. If not provided, App Runner associates the latest revision of a
            /// default auto scaling configuration.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1011
            /// Pattern: arn:aws(-[\w]+)*:[a-z0-9-\\. ]{0,63}:[a-z0-9-\\. ]{0,63}:[0-9]{12}:(\w|\/|-){1,1011}
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AutoScalingConfigurationArn { get; set; }

        }

        public string Type { get; } = "AWS::AppRunner::Service";

        public ServiceProperties Properties { get; } = new ServiceProperties();

    }

    public static class ServiceAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ServiceId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ServiceId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ServiceArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ServiceArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ServiceUrl = new ResourceAttribute<Union<string, IntrinsicFunction>>("ServiceUrl");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
    }
}
