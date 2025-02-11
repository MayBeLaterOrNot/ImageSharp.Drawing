// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

namespace SixLabors.ImageSharp.Drawing
{
    /// <summary>
    /// Provides options for calculating intersection points.
    /// </summary>
    public enum IntersectionRule
    {
        /// <summary>
        /// Only odd numbered sub-regions are filled.
        /// </summary>
        EvenOdd = 0,

        /// <summary>
        /// Only non-zero sub-regions are filled.
        /// </summary>
        NonZero = 1
    }
}
