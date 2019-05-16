using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.ApplicationVersion
{
    /// <summary>
    /// AWS::ElasticBeanstalk::ApplicationVersion
    /// The AWS::ElasticBeanstalk::ApplicationVersion resource is an AWS Elastic Beanstalk resource type that
    /// specifies an application version, an iteration of deployable code, for an Elastic Beanstalk application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-version.html
    /// </summary>
    public class ApplicationVersionResource : ResourceBase
    {
        public class ApplicationVersionProperties
        {
            /// <summary>
            /// ApplicationName
            /// The name of the Elastic Beanstalk application that is associated with this application version.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// Description
            /// A description of this application version.
            /// Required: No
            /// Type: String
            /// Maximum: 200
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// SourceBundle
            /// The Amazon S3 bucket and key that identify the location of the source bundle for this version.
            /// Note The Amazon S3 bucket must be in the same region as the environment.
            /// Required: Yes
            /// Type: SourceBundle
            /// Update requires: Replacement
            /// </summary>
			public SourceBundle SourceBundle { get; set; }

        }

        public string Type { get; } = "AWS::ElasticBeanstalk::ApplicationVersion";

        public ApplicationVersionProperties Properties { get; } = new ApplicationVersionProperties();

    }
}
