using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource DataSourceToIndexFieldMappingList
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourcetoindexfieldmappinglist.html
    /// </summary>
    public class DataSourceToIndexFieldMappingList
    {

        /// <summary>
        /// DataSourceToIndexFieldMappingList_
        /// </summary>
        [JsonProperty("DataSourceToIndexFieldMappingList")]
        public List<DataSourceToIndexFieldMapping> DataSourceToIndexFieldMappingList_ { get; set; }

    }
}
