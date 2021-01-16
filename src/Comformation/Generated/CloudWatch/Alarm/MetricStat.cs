using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.Alarm
{
    /// <summary>
    /// AWS::CloudWatch::Alarm MetricStat
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metricstat.html
    /// </summary>
    public class MetricStat
    {

        /// <summary>
        /// Metric
        /// 		
        /// The metric to return, including the metric name, namespace, and dimensions.
        /// 	
        /// Required: Yes
        /// Type: Metric
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Metric")]
        public Metric Metric { get; set; }

        /// <summary>
        /// Period
        /// 		
        /// The granularity, in seconds, of the returned data points. For metrics with regular resolution, a
        /// period can 			be as short as one minute (60 seconds) and must be a multiple of 60. For
        /// high-resolution metrics that are collected 			at intervals of less than one minute, the period can
        /// be 1, 5, 10, 30, 60, or any multiple of 60. High-resolution metrics 			are those metrics stored by a
        /// PutMetricData call that includes a StorageResolution of 1 second.
        /// 			
        /// If the StartTime parameter specifies a time stamp that is greater than 				3 hours ago, you must
        /// specify the period as follows or no data points in that time range is returned:
        /// 			
        /// 				 				 				 			 Start time between 3 hours and 15 days ago - Use a multiple of 60 seconds (1
        /// minute). Start time between 15 and 63 days ago - Use a multiple of 300 seconds (5 minutes). Start
        /// time greater than 63 days ago - Use a multiple of 3600 seconds (1 hour).
        /// 	
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Period")]
        public Union<int, IntrinsicFunction> Period { get; set; }

        /// <summary>
        /// Stat
        /// 		
        /// The statistic to return. It can include any CloudWatch statistic or extended statistic. 		 For a
        /// list of valid values, see the table in 		 Statistics in the Amazon CloudWatch User Guide.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Stat")]
        public Union<string, IntrinsicFunction> Stat { get; set; }

        /// <summary>
        /// Unit
        /// 		
        /// The unit to use for the returned data points.
        /// Valid values are: Seconds, Microseconds, Milliseconds, Bytes, Kilobytes, Megabytes, Gigabytes,
        /// Terabytes, Bits, Kilobits, Megabits, Gigabits, Terabits, Percent, Count, Bytes/Second,
        /// Kilobytes/Second, Megabytes/Second, Gigabytes/Second, Terabytes/Second, Bits/Second,
        /// Kilobits/Second, Megabits/Second, Gigabits/Second, Terabits/Second, Count/Second, or None.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: Bits | Bits/Second | Bytes | Bytes/Second | Count | Count/Second | Gigabits |
        /// Gigabits/Second | Gigabytes | Gigabytes/Second | Kilobits | Kilobits/Second | Kilobytes |
        /// Kilobytes/Second | Megabits | Megabits/Second | Megabytes | Megabytes/Second | Microseconds |
        /// Milliseconds | None | Percent | Seconds | Terabits | Terabits/Second | Terabytes | Terabytes/Second
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Unit")]
        public Union<string, IntrinsicFunction> Unit { get; set; }

    }
}
