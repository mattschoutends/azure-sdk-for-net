// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Basic custom model information. </summary>
    internal partial class ModelInfo_internal
    {
        /// <summary> Initializes a new instance of ModelInfo_internal. </summary>
        internal ModelInfo_internal()
        {
        }

        /// <summary> Initializes a new instance of ModelInfo_internal. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="status"> Status of the model. </param>
        /// <param name="createdDateTime"> Date and time (UTC) when the model was created. </param>
        /// <param name="lastUpdatedDateTime"> Date and time (UTC) when the status was last updated. </param>
        internal ModelInfo_internal(Guid modelId, ModelStatus status, DateTimeOffset createdDateTime, DateTimeOffset lastUpdatedDateTime)
        {
            ModelId = modelId;
            Status = status;
            CreatedDateTime = createdDateTime;
            LastUpdatedDateTime = lastUpdatedDateTime;
        }

        /// <summary> Model identifier. </summary>
        public Guid ModelId { get; internal set; }
        /// <summary> Status of the model. </summary>
        public ModelStatus Status { get; internal set; }
        /// <summary> Date and time (UTC) when the model was created. </summary>
        public DateTimeOffset CreatedDateTime { get; internal set; }
        /// <summary> Date and time (UTC) when the status was last updated. </summary>
        public DateTimeOffset LastUpdatedDateTime { get; internal set; }
    }
}