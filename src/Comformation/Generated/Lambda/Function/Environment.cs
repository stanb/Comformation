using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Function
{
    /// <summary>
    /// AWS Lambda Function Environment
    /// Environment is a property of the AWS::Lambda::Function resource that specifies key-value pairs that the AWS
    /// Lambda (Lambda) function can access so that you can apply configuration changes, such as test and production
    /// environment configurations, without changing the function code.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-environment.html
    /// </summary>
    public class Environment
    {

        /// <summary>
        /// Variables
        /// A map of key-value pairs that the Lambda function can access.
        /// Required: No
        /// Type: Mapping of key-value pairs
        /// </summary>
        [JsonProperty("Variables")]
        public Union<Dictionary<string, string>, IntrinsicFunction> Variables { get; set; }

    }
}
