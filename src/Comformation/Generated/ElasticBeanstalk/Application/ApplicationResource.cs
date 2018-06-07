using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.Application
{
    /// <summary>
    /// AWS::ElasticBeanstalk::Application
    /// Creates an Elastic Beanstalk application.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk.html
    /// </summary>
    public class ApplicationResource : ResourceBase
    {
        public class ApplicationProperties
        {
            /// <summary>
            /// ApplicationName
            /// A name for the Elastic Beanstalk application. If you don't specify a name, AWS CloudFormation
            /// generates a unique physical ID and uses that ID for the application name. For more information, see
            /// Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk.html#cfn-elasticbeanstalk-application-name
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// Description
            /// An optional description of this application.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk.html#cfn-elasticbeanstalk-application-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ResourceLifecycleConfig
            /// Defines lifecycle settings for resources that belong to the application, and the service role that
            /// Elastic Beanstalk assumes in order to apply lifecycle settings.
            /// Required: No
            /// Type: Elastic Beanstalk Application ApplicationResourceLifecycleConfig
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk.html#cfn-elasticbeanstalk-application-resourcelifecycleconfig
            /// </summary>
			public Union<ApplicationResourceLifecycleConfig, IntrinsicFunction> ResourceLifecycleConfig { get; set; }

        }
    
        public string Type { get; } = "AWS::ElasticBeanstalk::Application";
        
        public ApplicationProperties Properties { get; } = new ApplicationProperties();
    }
}
