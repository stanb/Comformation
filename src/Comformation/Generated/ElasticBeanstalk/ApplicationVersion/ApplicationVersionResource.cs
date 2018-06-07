using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.ApplicationVersion
{
    /// <summary>
    /// AWS::ElasticBeanstalk::ApplicationVersion
    /// Creates an application version, an iteration of deployable code, for an Elastic Beanstalk application.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-version.html
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-version.html#cfn-elasticbeanstalk-applicationversion-applicationname
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// Description
            /// A description of this application version.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-version.html#cfn-elasticbeanstalk-applicationversion-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// SourceBundle
            /// The location of the source bundle for this version.
            /// Required: Yes
            /// Type: Source Bundle
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-version.html#cfn-elasticbeanstalk-applicationversion-sourcebundle
            /// </summary>
			public Union<SourceBundle, IntrinsicFunction> SourceBundle { get; set; }

        }
    
        public string Type { get; } = "AWS::ElasticBeanstalk::ApplicationVersion";
        
        public ApplicationVersionProperties Properties { get; } = new ApplicationVersionProperties();
    }
}
