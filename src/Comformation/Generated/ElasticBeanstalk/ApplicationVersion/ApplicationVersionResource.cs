using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.ApplicationVersion
{
    /// <summary>
    /// AWS::ElasticBeanstalk::ApplicationVersion
    /// Creates an application version, an iteration of deployable code, for an Elastic Beanstalk application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-version.html
    /// </summary>
    public class ApplicationVersionResource : ResourceBase
    {
        public class ApplicationVersionProperties
        {
            /// <summary>
            /// ApplicationName
            /// Name of the Elastic Beanstalk application that is associated with this application version.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// Description
            /// A description of this application version.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// SourceBundle
            /// The location of the source bundle for this version.
            /// Required: Yes
            /// Type: Source Bundle
            /// Update requires: Replacement
            /// </summary>
			public SourceBundle SourceBundle { get; set; }

        }
    
        public string Type { get; } = "AWS::ElasticBeanstalk::ApplicationVersion";
        
        public ApplicationVersionProperties Properties { get; } = new ApplicationVersionProperties();

    }
}
