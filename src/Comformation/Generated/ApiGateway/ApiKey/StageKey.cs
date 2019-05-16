using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.ApiKey
{
    /// <summary>
    /// AWS::ApiGateway::ApiKey StageKey
    /// StageKey is a property of the AWS::ApiGateway::ApiKey resource that specifies the stage to associate with the
    /// API key. This association allows only clients with the key to make requests to methods in that stage.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-apikey-stagekey.html
    /// </summary>
    public class StageKey
    {

        /// <summary>
        /// RestApiId
        /// The ID of a RestApi resource that includes the stage with which you want to associate the API key.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RestApiId")]
        public Union<string, IntrinsicFunction> RestApiId { get; set; }

        /// <summary>
        /// StageName
        /// The name of the stage with which to associate the API key. The stage must be included in the RestApi
        /// resource that you specified in the RestApiId property.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StageName")]
        public Union<string, IntrinsicFunction> StageName { get; set; }

    }
}
