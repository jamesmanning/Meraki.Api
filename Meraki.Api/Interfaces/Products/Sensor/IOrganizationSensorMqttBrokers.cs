﻿namespace Meraki.Api.Interfaces.Products.Sensor;

public interface IOrganizationSensorMqttBrokers
{
	/// <summary>
	/// Return the sensor settings of an MQTT broker
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="mqttBrokerId">The broker id</param>
	[ApiOperationId("getNetworkSensorMqttBroker")]
	[Get("/networks/{networkId}/sensor/mqttBrokers/{mqttBrokerId}")]
	Task<SensorMqttBroker> GetNetworkSensorMqttBrokerAsync(
		string networkId,
		string mqttBrokerId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List the sensor settings of all MQTT brokers for this network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSensorMqttBrokers")]
	[Get("/networks/{networkId}/sensor/mqttBrokers")]
	Task<List<SensorMqttBroker>> GetNetworkSensorMqttBrokersAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the sensor settings of an MQTT broker.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="mqttBrokerId">The broker id</param>
	/// <param name="mqttBrokerUpdate">Body for updating a SensorMqttBroker</param>
	[ApiOperationId("updateNetworkSensorMqttBroker")]
	[Get("/networks/{networkId}/sensor/mqttBrokers/{mqttBrokerId}")]
	Task<SensorMqttBroker> UpdateNetworkSensorMqttBrokerAsync(
		string networkId,
		string mqttBrokerId,
		[Body] SensorMqttBrokerUpdate sensorMqttUpdate,
		CancellationToken cancellationToken = default
		);
}
