using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.UsagePlanKey
{
    /// <summary>
    /// AWS::ApiGateway::UsagePlanKey
    /// The AWS::ApiGateway::UsagePlanKey resource associates an Amazon API Gateway API key with an API Gateway usage
    /// plan. This association determines which users the usage plan is applied to.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplankey.html
    /// </summary>
    public class UsagePlanKeyResource : ResourceBase
    {
        public class UsagePlanKeyProperties
        {
            /// <summary>
            /// KeyId
            /// The ID of the usage plan key.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KeyId { get; set; }

            /// <summary>
            /// KeyType
            /// The type of usage plan key. Currently, the valid key type is API_KEY.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KeyType { get; set; }

            /// <summary>
            /// UsagePlanId
            /// The value of the usage plan key.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> UsagePlanId { get; set; }

        }
    
        public string Type { get; } = "AWS::ApiGateway::UsagePlanKey";
        
        public UsagePlanKeyProperties Properties { get; } = new UsagePlanKeyProperties();

    }
}
