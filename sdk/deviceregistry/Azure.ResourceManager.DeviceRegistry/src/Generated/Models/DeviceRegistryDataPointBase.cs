// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    /// <summary> Defines the data point properties. </summary>
    public partial class DeviceRegistryDataPointBase
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DeviceRegistryDataPointBase"/>. </summary>
        /// <param name="name"> The name of the data point. </param>
        /// <param name="dataSource"> The address of the source of the data in the asset (e.g. URL) so that a client can access the data source on the asset. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="dataSource"/> is null. </exception>
        public DeviceRegistryDataPointBase(string name, string dataSource)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(dataSource, nameof(dataSource));

            Name = name;
            DataSource = dataSource;
        }

        /// <summary> Initializes a new instance of <see cref="DeviceRegistryDataPointBase"/>. </summary>
        /// <param name="name"> The name of the data point. </param>
        /// <param name="dataSource"> The address of the source of the data in the asset (e.g. URL) so that a client can access the data source on the asset. </param>
        /// <param name="dataPointConfiguration"> Stringified JSON that contains connector-specific configuration for the data point. For OPC UA, this could include configuration like, publishingInterval, samplingInterval, and queueSize. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceRegistryDataPointBase(string name, string dataSource, string dataPointConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            DataSource = dataSource;
            DataPointConfiguration = dataPointConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DeviceRegistryDataPointBase"/> for deserialization. </summary>
        internal DeviceRegistryDataPointBase()
        {
        }

        /// <summary> The name of the data point. </summary>
        public string Name { get; set; }
        /// <summary> The address of the source of the data in the asset (e.g. URL) so that a client can access the data source on the asset. </summary>
        public string DataSource { get; set; }
        /// <summary> Stringified JSON that contains connector-specific configuration for the data point. For OPC UA, this could include configuration like, publishingInterval, samplingInterval, and queueSize. </summary>
        public string DataPointConfiguration { get; set; }
    }
}
