using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow ZendeskDestinationProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-zendeskdestinationproperties.html
    /// </summary>
    public class ZendeskDestinationProperties
    {

        /// <summary>
        /// Object
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Object")]
        public Union<string, IntrinsicFunction> Object { get; set; }

        /// <summary>
        /// ErrorHandlingConfig
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: ErrorHandlingConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ErrorHandlingConfig")]
        public ErrorHandlingConfig ErrorHandlingConfig { get; set; }

        /// <summary>
        /// IdFieldNames
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IdFieldNames")]
        public List<Union<string, IntrinsicFunction>> IdFieldNames { get; set; }

        /// <summary>
        /// WriteOperationType
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WriteOperationType")]
        public Union<string, IntrinsicFunction> WriteOperationType { get; set; }

    }
}
