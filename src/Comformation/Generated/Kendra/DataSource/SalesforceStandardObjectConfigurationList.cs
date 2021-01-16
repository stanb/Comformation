using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource SalesforceStandardObjectConfigurationList
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcestandardobjectconfigurationlist.html
    /// </summary>
    public class SalesforceStandardObjectConfigurationList
    {

        /// <summary>
        /// SalesforceStandardObjectConfigurationList_
        /// </summary>
        [JsonProperty("SalesforceStandardObjectConfigurationList")]
        public List<SalesforceStandardObjectConfiguration> SalesforceStandardObjectConfigurationList_ { get; set; }

    }
}
