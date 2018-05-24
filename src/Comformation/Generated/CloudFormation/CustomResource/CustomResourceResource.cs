using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.CustomResource
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cfn-customresource.html
    /// </summary>
    public class CustomResourceResource : ResourceBase
    {
        public class CustomResourceProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cfn-customresource.html#cfn-customresource-servicetoken
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceToken { get; set; }

        }
    
        public string Type { get; } = "AWS::CloudFormation::CustomResource";
        
        public CustomResourceProperties Properties { get; } = new CustomResourceProperties();
    }
}
