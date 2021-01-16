using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource SalesforceChatterFeedIncludeFilterTypes
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcechatterfeedincludefiltertypes.html
    /// </summary>
    public class SalesforceChatterFeedIncludeFilterTypes
    {

        /// <summary>
        /// SalesforceChatterFeedIncludeFilterTypes_
        /// </summary>
        [JsonProperty("SalesforceChatterFeedIncludeFilterTypes")]
        public List<Union<string, IntrinsicFunction>> SalesforceChatterFeedIncludeFilterTypes_ { get; set; }

    }
}
