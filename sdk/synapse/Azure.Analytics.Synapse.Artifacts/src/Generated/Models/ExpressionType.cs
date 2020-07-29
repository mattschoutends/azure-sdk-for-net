// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Expression type. </summary>
    public readonly partial struct ExpressionType : IEquatable<ExpressionType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ExpressionType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExpressionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ExpressionValue = "Expression";

        /// <summary> Expression. </summary>
        public static ExpressionType Expression { get; } = new ExpressionType(ExpressionValue);
        /// <summary> Determines if two <see cref="ExpressionType"/> values are the same. </summary>
        public static bool operator ==(ExpressionType left, ExpressionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExpressionType"/> values are not the same. </summary>
        public static bool operator !=(ExpressionType left, ExpressionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExpressionType"/>. </summary>
        public static implicit operator ExpressionType(string value) => new ExpressionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExpressionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExpressionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
