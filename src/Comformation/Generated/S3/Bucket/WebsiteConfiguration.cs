using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html
    /// </summary>
    public class WebsiteConfiguration
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html#cfn-s3-websiteconfiguration-errordocument
        /// </summary>
        [JsonProperty("ErrorDocument")]
        public Union<string, IntrinsicFunction> ErrorDocument { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html#cfn-s3-websiteconfiguration-indexdocument
        /// </summary>
        [JsonProperty("IndexDocument")]
        public Union<string, IntrinsicFunction> IndexDocument { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html#cfn-s3-websiteconfiguration-redirectallrequeststo
        /// </summary>
        [JsonProperty("RedirectAllRequestsTo")]
        public Union<RedirectAllRequestsTo, IntrinsicFunction> RedirectAllRequestsTo { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html#cfn-s3-websiteconfiguration-routingrules
        /// </summary>
        [JsonProperty("RoutingRules")]
        public Union<List<RoutingRule>, IntrinsicFunction> RoutingRules { get; set; }

    }
}
