﻿namespace TspLibNet.DistanceFunctions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using TspLibNet.Extensions;
    using TspLibNet.Graph.Nodes;

    /// <summary>
    /// Euclidean distance function
    /// </summary>
    public class Euclidean : DistanceFunctionBase
    {
        /// <summary>
        /// Gets distance from node A to node B
        /// </summary>
        /// <param name="a">node A</param>
        /// <param name="b">node B</param>
        /// <returns>Distance between node A and node B</returns>
        public override double Distance(Node2D a, Node2D b)
        {
            double xd = a.X - b.X;
            double yd = a.Y - b.Y;
            return MathExtensions.NearestInt(xd * xd + yd * yd);
        }

        /// <summary>
        /// Gets distance from node A to node B
        /// </summary>
        /// <param name="a">node A</param>
        /// <param name="b">node B</param>
        /// <returns>Distance between node A and node B</returns>
        public override double Distance(Node3D a, Node3D b)
        {
            double xd = a.X - b.X;
            double yd = a.Y - b.Y;
            double zd = a.Z - b.Z;
            return MathExtensions.NearestInt(xd * xd + yd * yd + zd * zd);
        }
    }
}