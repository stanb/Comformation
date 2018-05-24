using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Method
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-methodresponse.html
    /// </summary>
    public class MethodResponse
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-methodresponse.html#cfn-apigateway-method-methodresponse-responsemodels
        /// </summary>
        [JsonProperty("ResponseModels")]
        public Union<Dictionary<string, string>, IntrinsicFunction> ResponseModels { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-methodresponse.html#cfn-apigateway-method-methodresponse-responseparameters
        /// </summary>
        [JsonProperty("ResponseParameters")]
        public Union<Dictionary<string, bool>, IntrinsicFunction> ResponseParameters { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-methodresponse.html#cfn-apigateway-method-methodresponse-statuscode
        /// </summary>
        [JsonProperty("StatusCode")]
        public Union<string, IntrinsicFunction> StatusCode { get; set; }

    }
}
