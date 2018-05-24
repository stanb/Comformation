using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Service
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-networkconfiguration.html
    /// </summary>
    public class NetworkConfiguration
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-networkconfiguration.html#cfn-ecs-service-networkconfiguration-awsvpcconfiguration
        /// </summary>
        [JsonProperty("AwsvpcConfiguration")]
        public Union<AwsVpcConfiguration, IntrinsicFunction> AwsvpcConfiguration { get; set; }

    }
}
