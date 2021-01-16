using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource OneDriveUserList
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-onedriveuserlist.html
    /// </summary>
    public class OneDriveUserList
    {

        /// <summary>
        /// OneDriveUserList_
        /// </summary>
        [JsonProperty("OneDriveUserList")]
        public List<Union<string, IntrinsicFunction>> OneDriveUserList_ { get; set; }

    }
}
