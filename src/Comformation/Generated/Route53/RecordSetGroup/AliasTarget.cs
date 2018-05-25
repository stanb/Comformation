using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.RecordSetGroup
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-aliastarget.html
    /// </summary>
    public class AliasTarget
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-aliastarget.html#cfn-route53-aliastarget-dnshostname
        /// </summary>
        [JsonProperty("DNSName")]
        public Union<string, IntrinsicFunction> DNSName { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-aliastarget.html#cfn-route53-aliastarget-evaluatetargethealth
        /// </summary>
        [JsonProperty("EvaluateTargetHealth")]
        public Union<bool, IntrinsicFunction> EvaluateTargetHealth { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-aliastarget.html#cfn-route53-aliastarget-hostedzoneid
        /// </summary>
        [JsonProperty("HostedZoneId")]
        public Union<string, IntrinsicFunction> HostedZoneId { get; set; }

    }
}
