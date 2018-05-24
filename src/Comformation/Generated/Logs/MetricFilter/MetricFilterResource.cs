using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Logs.MetricFilter
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-metricfilter.html
    /// </summary>
    public class MetricFilterResource : ResourceBase
    {
        public class MetricFilterProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-metricfilter.html#cfn-cwl-metricfilter-filterpattern
            /// </summary>
			public Union<string, IntrinsicFunction> FilterPattern { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-metricfilter.html#cfn-cwl-metricfilter-loggroupname
            /// </summary>
			public Union<string, IntrinsicFunction> LogGroupName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-metricfilter.html#cfn-cwl-metricfilter-metrictransformations
            /// </summary>
			public Union<List<MetricTransformation>, IntrinsicFunction> MetricTransformations { get; set; }

        }
    
        public string Type { get; } = "AWS::Logs::MetricFilter";
        
        public MetricFilterProperties Properties { get; } = new MetricFilterProperties();
    }
}
