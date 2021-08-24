using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3ObjectLambda.AccessPoint
{
    /// <summary>
    /// AWS::S3ObjectLambda::AccessPoint TransformationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3objectlambda-accesspoint-transformationconfiguration.html
    /// </summary>
    public class TransformationConfiguration
    {

        /// <summary>
        /// Actions
        /// A container for the action of an Object Lambda Access Point configuration. Valid input is GetObject.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Actions")]
        public List<Union<string, IntrinsicFunction>> Actions { get; set; }

        /// <summary>
        /// ContentTransformation
        /// A container for the content transformation of an Object Lambda Access Point configuration. Can
        /// include the FunctionArn and FunctionPayload. For more information, see AwsLambdaTransformation in
        /// the Amazon S3 API Reference.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContentTransformation")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> ContentTransformation { get; set; }

    }
}
