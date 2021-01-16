using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource DataSourceInclusionsExclusionsStrings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourceinclusionsexclusionsstrings.html
    /// </summary>
    public class DataSourceInclusionsExclusionsStrings
    {

        /// <summary>
        /// DataSourceInclusionsExclusionsStrings_
        /// </summary>
        [JsonProperty("DataSourceInclusionsExclusionsStrings")]
        public List<Union<string, IntrinsicFunction>> DataSourceInclusionsExclusionsStrings_ { get; set; }

    }
}
