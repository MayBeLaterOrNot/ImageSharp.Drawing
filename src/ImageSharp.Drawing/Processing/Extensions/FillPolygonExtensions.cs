// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.Processing;

namespace SixLabors.ImageSharp.Drawing.Processing
{
    /// <summary>
    /// Adds extensions that allow the filling of closed linear polygons.
    /// </summary>
    public static class FillPolygonExtensions
    {
        /// <summary>
        /// Flood fills the image in the shape of a linear polygon described by the points
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="points">The points.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext FillPolygon(
            this IImageProcessingContext source,
            DrawingOptions options,
            Brush brush,
            params PointF[] points) =>
            source.Fill(options, brush, new Polygon(new LinearLineSegment(points)));

        /// <summary>
        /// Flood fills the image in the shape of a linear polygon described by the points
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="points">The points.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext FillPolygon(
            this IImageProcessingContext source,
            Brush brush,
            params PointF[] points) =>
            source.Fill(brush, new Polygon(new LinearLineSegment(points)));

        /// <summary>
        /// Flood fills the image in the shape of a linear polygon described by the points
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="options">The options.</param>
        /// <param name="color">The color.</param>
        /// <param name="points">The points.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext FillPolygon(
            this IImageProcessingContext source,
            DrawingOptions options,
            Color color,
            params PointF[] points) =>
            source.Fill(options, new SolidBrush(color), new Polygon(new LinearLineSegment(points)));

        /// <summary>
        /// Flood fills the image in the shape of a linear polygon described by the points
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="color">The color.</param>
        /// <param name="points">The points.</param>
        /// <returns>The <see cref="IImageProcessingContext"/> to allow chaining of operations.</returns>
        public static IImageProcessingContext FillPolygon(
            this IImageProcessingContext source,
            Color color,
            params PointF[] points) =>
            source.Fill(new SolidBrush(color), new Polygon(new LinearLineSegment(points)));
    }
}
