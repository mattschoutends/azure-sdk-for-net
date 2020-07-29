// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The OAuth 2.0 authentication mechanism used for authentication. ServiceAuthentication can only be used on self-hosted IR. </summary>
    public readonly partial struct GoogleBigQueryAuthenticationType : IEquatable<GoogleBigQueryAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="GoogleBigQueryAuthenticationType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GoogleBigQueryAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServiceAuthenticationValue = "ServiceAuthentication";
        private const string UserAuthenticationValue = "UserAuthentication";

        /// <summary> ServiceAuthentication. </summary>
        public static GoogleBigQueryAuthenticationType ServiceAuthentication { get; } = new GoogleBigQueryAuthenticationType(ServiceAuthenticationValue);
        /// <summary> UserAuthentication. </summary>
        public static GoogleBigQueryAuthenticationType UserAuthentication { get; } = new GoogleBigQueryAuthenticationType(UserAuthenticationValue);
        /// <summary> Determines if two <see cref="GoogleBigQueryAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(GoogleBigQueryAuthenticationType left, GoogleBigQueryAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GoogleBigQueryAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(GoogleBigQueryAuthenticationType left, GoogleBigQueryAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GoogleBigQueryAuthenticationType"/>. </summary>
        public static implicit operator GoogleBigQueryAuthenticationType(string value) => new GoogleBigQueryAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GoogleBigQueryAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GoogleBigQueryAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
