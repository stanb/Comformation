using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.Application
{
    /// <summary>
    /// AWS::ElasticBeanstalk::Application
    /// The AWS::ElasticBeanstalk::Application resource is an AWS Elastic Beanstalk resource type that specifies an
    /// Elastic Beanstalk application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk.html
    /// </summary>
    public class ApplicationResource : ResourceBase
    {
        public class ApplicationProperties
        {
            /// <summary>
            /// ApplicationName
            /// A name for the Elastic Beanstalk application. If you don&#39;t specify a name, AWS CloudFormation
            /// generates a unique physical ID and uses that ID for the application name. For more information, see
            /// Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// Description
            /// Your description of the application.
            /// Required: No
            /// Type: String
            /// Maximum: 200
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ResourceLifecycleConfig
            /// Specifies an application resource lifecycle configuration to prevent your application from
            /// accumulating too many versions.
            /// Required: No
            /// Type: ApplicationResourceLifecycleConfig
            /// Update requires: No interruption
            /// </summary>
			public ApplicationResourceLifecycleConfig ResourceLifecycleConfig { get; set; }

        }

        public string Type { get; } = "AWS::ElasticBeanstalk::Application";

        public ApplicationProperties Properties { get; } = new ApplicationProperties();

    }
}
