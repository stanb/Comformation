using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.UsagePlanKey
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplankey.html
    /// </summary>
    public class UsagePlanKeyResource : ResourceBase
    {
        public class UsagePlanKeyProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplankey.html#cfn-apigateway-usageplankey-keyid
            /// </summary>
			public Union<string, IntrinsicFunction> KeyId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplankey.html#cfn-apigateway-usageplankey-keytype
            /// </summary>
			public Union<string, IntrinsicFunction> KeyType { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplankey.html#cfn-apigateway-usageplankey-usageplanid
            /// </summary>
			public Union<string, IntrinsicFunction> UsagePlanId { get; set; }

        }
    
        public string Type { get; } = "AWS::ApiGateway::UsagePlanKey";
        
        public UsagePlanKeyProperties Properties { get; } = new UsagePlanKeyProperties();
    }
}
