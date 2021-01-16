using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Filter
{
    /// <summary>
    /// AWS::GuardDuty::Filter FindingCriteria
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-findingcriteria.html
    /// </summary>
    public class FindingCriteria
    {

        /// <summary>
        /// Criterion
        /// Represents a map of finding properties that match specified conditions and values when querying
        /// findings.
        /// For a mapping of JSON criterion to their console equivalent see Finding criteria. The following are
        /// the available criterion:
        /// accountId region confidence id resource. accessKeyDetails. accessKeyId resource. accessKeyDetails.
        /// principalId resource. accessKeyDetails. userName resource. accessKeyDetails. userType resource.
        /// instanceDetails. iamInstanceProfile. id resource. instanceDetails. imageId resource.
        /// instanceDetails. instanceId resource. instanceDetails. outpostArn resource. instanceDetails.
        /// networkInterfaces. ipv6Addresses resource. instanceDetails. networkInterfaces. privateIpAddresses.
        /// privateIpAddress resource. instanceDetails. networkInterfaces. publicDnsName resource.
        /// instanceDetails. networkInterfaces. publicIp resource. instanceDetails. networkInterfaces.
        /// securityGroups. groupId resource. instanceDetails. networkInterfaces. securityGroups. groupName
        /// resource. instanceDetails. networkInterfaces. subnetId resource. instanceDetails. networkInterfaces.
        /// vpcId resource. instanceDetails. tags. key resource. instanceDetails. tags. value resource.
        /// resourceType service. action. actionType service. action. awsApiCallAction. api service. action.
        /// awsApiCallAction. callerType service. action. awsApiCallAction. errorCode service. action.
        /// awsApiCallAction. remoteIpDetails. city. cityName service. action. awsApiCallAction.
        /// remoteIpDetails. country. countryName service. action. awsApiCallAction. remoteIpDetails.
        /// ipAddressV4 service. action. awsApiCallAction. remoteIpDetails. organization. asn service. action.
        /// awsApiCallAction. remoteIpDetails. organization. asnOrg service. action. awsApiCallAction.
        /// serviceName service. action. dnsRequestAction. domain service. action. networkConnectionAction.
        /// blocked service. action. networkConnectionAction. connectionDirection service. action.
        /// networkConnectionAction. localPortDetails. port service. action. networkConnectionAction. protocol
        /// service. action. networkConnectionAction. localIpDetails. ipAddressV4 service. action.
        /// networkConnectionAction. remoteIpDetails. city. cityName service. action. networkConnectionAction.
        /// remoteIpDetails. country. countryName service. action. networkConnectionAction. remoteIpDetails.
        /// ipAddressV4 service. action. networkConnectionAction. remoteIpDetails. organization. asn service.
        /// action. networkConnectionAction. remoteIpDetails. organization. asnOrg service. action.
        /// networkConnectionAction. remotePortDetails. port service. additionalInfo. threatListName service.
        /// archived When this attribute is set to TRUE, only archived findings are listed. When it&#39;s set to
        /// FALSE, only unarchived findings are listed. When this attribute is not set, all existing findings
        /// are listed. service. resourceRole severity type updatedAt Type: ISO 8601 string format:
        /// YYYY-MM-DDTHH:MM:SS. SSSZ or YYYY-MM-DDTHH:MM:SSZ depending on whether the value contains
        /// milliseconds.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Criterion")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Criterion { get; set; }

        /// <summary>
        /// ItemType
        /// Specifies the condition to be applied to a single field when filtering through findings.
        /// Required: No
        /// Type: Condition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ItemType")]
        public Condition ItemType { get; set; }

    }
}
