// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Iot.TimeSeriesInsights.Models
{
    /// <summary> Kind of the expansion of hierarchy nodes. When it is set to &apos;UntilChildren&apos;, the hierarchy nodes are expanded recursively until there is more than one child. When it is set to &apos;OneLevel&apos;, the hierarchies are expanded only at the single level matching path search instances parameter. Optional, default is &apos;UntilChildren&apos;. </summary>
    public readonly partial struct HierarchiesExpandKind : IEquatable<HierarchiesExpandKind>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="HierarchiesExpandKind"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HierarchiesExpandKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UntilChildrenValue = "UntilChildren";
        private const string OneLevelValue = "OneLevel";

        /// <summary> UntilChildren. </summary>
        public static HierarchiesExpandKind UntilChildren { get; } = new HierarchiesExpandKind(UntilChildrenValue);
        /// <summary> OneLevel. </summary>
        public static HierarchiesExpandKind OneLevel { get; } = new HierarchiesExpandKind(OneLevelValue);
        /// <summary> Determines if two <see cref="HierarchiesExpandKind"/> values are the same. </summary>
        public static bool operator ==(HierarchiesExpandKind left, HierarchiesExpandKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HierarchiesExpandKind"/> values are not the same. </summary>
        public static bool operator !=(HierarchiesExpandKind left, HierarchiesExpandKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HierarchiesExpandKind"/>. </summary>
        public static implicit operator HierarchiesExpandKind(string value) => new HierarchiesExpandKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HierarchiesExpandKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HierarchiesExpandKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
