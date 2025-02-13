// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    [PersistableModelProxy(typeof(UnknownProtectableContainer))]
    public partial class ProtectableContainer : IUtf8JsonSerializable, IJsonModel<ProtectableContainer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProtectableContainer>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProtectableContainer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectableContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProtectableContainer)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            writer.WritePropertyName("protectableContainerType"u8);
            writer.WriteStringValue(ProtectableContainerType.ToSerialString());
            if (Optional.IsDefined(HealthStatus))
            {
                writer.WritePropertyName("healthStatus"u8);
                writer.WriteStringValue(HealthStatus);
            }
            if (Optional.IsDefined(ContainerId))
            {
                writer.WritePropertyName("containerId"u8);
                writer.WriteStringValue(ContainerId);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ProtectableContainer IJsonModel<ProtectableContainer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectableContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProtectableContainer)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProtectableContainer(document.RootElement, options);
        }

        internal static ProtectableContainer DeserializeProtectableContainer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("protectableContainerType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "StorageContainer": return StorageProtectableContainer.DeserializeStorageProtectableContainer(element);
                    case "VMAppContainer": return VmAppContainerProtectableContainer.DeserializeVmAppContainerProtectableContainer(element);
                }
            }
            return UnknownProtectableContainer.DeserializeUnknownProtectableContainer(element);
        }

        BinaryData IPersistableModel<ProtectableContainer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectableContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProtectableContainer)} does not support '{options.Format}' format.");
            }
        }

        ProtectableContainer IPersistableModel<ProtectableContainer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectableContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProtectableContainer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProtectableContainer)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProtectableContainer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
