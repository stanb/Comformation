using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.CustomResource
{
    /// <summary>
    /// AWS::CloudFormation::CustomResource
    /// In a CloudFormation template, you use the AWS::CloudFormation::CustomResource or Custom::String resource type
    /// to specify custom resources.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cfn-customresource.html
    /// </summary>
    public class CustomResourceResource : ResourceBase
    {
        public class CustomResourceProperties
        {
            /// <summary>
            /// ServiceToken
            /// Note Only one property is defined by AWS for a custom resource: ServiceToken. All other properties
            /// are defined by the service provider.
            /// The service token that was given to the template developer by the service provider to access the
            /// service, such as an Amazon SNS topic ARN or Lambda function ARN. The service token must be from the
            /// same region in which you are creating the stack.
            /// Updates are not supported.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceToken { get; set; }

        }

        public string Type { get; } = "AWS::CloudFormation::CustomResource";

        public CustomResourceProperties Properties { get; } = new CustomResourceProperties();

    }
}
