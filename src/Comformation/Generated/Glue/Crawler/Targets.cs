using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Crawler
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-targets.html
    /// </summary>
    public class Targets
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-targets.html#cfn-glue-crawler-targets-s3targets
        /// </summary>
        [JsonProperty("S3Targets")]
        public Union<List<S3Target>, IntrinsicFunction> S3Targets { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-targets.html#cfn-glue-crawler-targets-jdbctargets
        /// </summary>
        [JsonProperty("JdbcTargets")]
        public Union<List<JdbcTarget>, IntrinsicFunction> JdbcTargets { get; set; }

    }
}
