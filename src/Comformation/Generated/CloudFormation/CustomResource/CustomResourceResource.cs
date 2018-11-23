using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.CustomResource
{
    /// <summary>
    /// AWS::CloudFormation::CustomResource
    /// In an AWS CloudFormation template, you use the AWS::CloudFormation::CustomResource or Custom::String resource
    /// type to specify custom resources.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cfn-customresource.html
    /// </summary>
    public class CustomResourceResource : ResourceBase
    {
        public class CustomResourceProperties
        {
            /// <summary>
            /// ServiceToken
            /// The service token that was given to the template developer by the service provider to access the
            /// service, such as an Amazon SNS topic ARN or Lambda function ARN. The service token must be from the
            /// same region in which you are creating the stack.
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceToken { get; set; }

        }

        public string Type { get; } = "AWS::CloudFormation::CustomResource";

        public CustomResourceProperties Properties { get; } = new CustomResourceProperties();

    }
}
