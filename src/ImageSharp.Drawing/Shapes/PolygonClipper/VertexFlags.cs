// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

using System;

namespace SixLabors.ImageSharp.Drawing.Shapes.PolygonClipper
{
    [Flags]
    internal enum VertexFlags
    {
        None = 0,
        OpenStart = 1,
        OpenEnd = 2,
        LocalMax = 4,
        LocalMin = 8
    }
}
