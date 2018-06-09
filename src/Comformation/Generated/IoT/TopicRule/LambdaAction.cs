using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS IoT TopicRule LambdaAction
    /// Lambda is a property of the Actions property that describes an action that invokes a Lambda function.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-lambdaaction.html
    /// </summary>
    public class LambdaAction
    {

        /// <summary>
        /// FunctionArn
        /// The ARN of the Lambda function.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("FunctionArn")]
        public Union<string, IntrinsicFunction> FunctionArn { get; set; }

    }
}
