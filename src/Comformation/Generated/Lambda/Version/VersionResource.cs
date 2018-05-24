using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Version
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html
    /// </summary>
    public class VersionResource : ResourceBase
    {
        public class VersionProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html#cfn-lambda-version-codesha256
            /// </summary>
			public Union<string, IntrinsicFunction> CodeSha256 { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html#cfn-lambda-version-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html#cfn-lambda-version-functionname
            /// </summary>
			public Union<string, IntrinsicFunction> FunctionName { get; set; }

        }
    
        public string Type { get; } = "AWS::Lambda::Version";
        
        public VersionProperties Properties { get; } = new VersionProperties();
    }

	public static class VersionAttributes
	{
        public static readonly ResourceAttribute<string> Version = new ResourceAttribute<string>("Version");
	}
}
