using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Function
{
    /// <summary>
    /// AWS::CloudFront::Function
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-function.html
    /// </summary>
    public class FunctionResource : ResourceBase
    {
        public class FunctionProperties
        {
            /// <summary>
            /// AutoPublish
            /// 		
            /// A flag that determines whether to automatically publish the function to the 			LIVE stage when it’s
            /// created. To automatically publish to the 			LIVE stage, set this property to true.
            /// 	
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AutoPublish { get; set; }

            /// <summary>
            /// FunctionCode
            /// 		
            /// The function code. For more information about writing a CloudFront function, see Writing function
            /// 			code for CloudFront Functions in the Amazon CloudFront Developer Guide.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FunctionCode { get; set; }

            /// <summary>
            /// FunctionConfig
            /// 		
            /// Contains configuration information about a CloudFront function.
            /// 	
            /// Required: No
            /// Type: FunctionConfig
            /// Update requires: No interruption
            /// </summary>
            public FunctionConfig FunctionConfig { get; set; }

            /// <summary>
            /// FunctionMetadata
            /// 		
            /// Contains metadata about a CloudFront function.
            /// 	
            /// Required: No
            /// Type: FunctionMetadata
            /// Update requires: No interruption
            /// </summary>
            public FunctionMetadata FunctionMetadata { get; set; }

            /// <summary>
            /// Name
            /// A name to identify the function.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: ^[a-zA-Z0-9-_]{1,64}$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::CloudFront::Function";

        public FunctionProperties Properties { get; } = new FunctionProperties();

    }

    public static class FunctionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> FunctionARN = new ResourceAttribute<Union<string, IntrinsicFunction>>("FunctionARN");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> FunctionMetadata_FunctionARN = new ResourceAttribute<Union<string, IntrinsicFunction>>("FunctionMetadata", "FunctionARN");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Stage = new ResourceAttribute<Union<string, IntrinsicFunction>>("Stage");
    }
}
