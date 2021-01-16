using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.StackSet
{
    /// <summary>
    /// AWS::CloudFormation::StackSet Parameter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-parameter.html
    /// </summary>
    public class Parameter
    {

        /// <summary>
        /// ParameterKey
        /// The key associated with the parameter. If you don&#39;t specify a key and value for a particular
        /// parameter, AWS CloudFormation uses the default value that is specified in your template.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParameterKey")]
        public Union<string, IntrinsicFunction> ParameterKey { get; set; }

        /// <summary>
        /// ParameterValue
        /// The input value associated with the parameter.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParameterValue")]
        public Union<string, IntrinsicFunction> ParameterValue { get; set; }

    }
}
