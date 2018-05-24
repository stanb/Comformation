using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.UsagePlan
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html
    /// </summary>
    public class UsagePlanResource : ResourceBase
    {
        public class UsagePlanProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-apistages
            /// </summary>
			public Union<List<ApiStage>, IntrinsicFunction> ApiStages { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-quota
            /// </summary>
			public Union<QuotaSettings, IntrinsicFunction> Quota { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-throttle
            /// </summary>
			public Union<ThrottleSettings, IntrinsicFunction> Throttle { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-usageplanname
            /// </summary>
			public Union<string, IntrinsicFunction> UsagePlanName { get; set; }

        }
    
        public string Type { get; } = "AWS::ApiGateway::UsagePlan";
        
        public UsagePlanProperties Properties { get; } = new UsagePlanProperties();
    }
}
