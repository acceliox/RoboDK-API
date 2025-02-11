﻿// ----------------------------------------------------------------------------------------------------------
// This file (RoboDK.cs) implements the RoboDK API for C#
// This file defines the following classes:
//     Mat: Matrix class, useful pose operations
//     RoboDK: API to interact with RoboDK
//     RoboDK.Item: Any item in the RoboDK station tree
//
// These classes are the objects used to interact with RoboDK and create macros.
// An item is an object in the RoboDK tree (it can be either a robot, an object, a tool, a frame, a program, ...).
// Items can be retrieved from the RoboDK station using the RoboDK() object (such as RoboDK.GetItem() method) 
//
// In this document: pose = transformation matrix = homogeneous matrix = 4x4 matrix
//
// More information about the RoboDK API for Python here:
//     https://robodk.com/doc/en/CsAPI/index.html
//     https://robodk.com/doc/en/RoboDK-API.html
//     https://robodk.com/doc/en/PythonAPI/index.html
//
// More information about RoboDK post processors here:
//     https://robodk.com/help#PostProcessor
//
// Visit the Matrix and Quaternions FAQ for more information about pose/homogeneous transformations
//     http://www.j3d.org/matrix_faq/matrfaq_latest.html
//
// This library includes the mathematics to operate with homogeneous matrices for robotics.
// ----------------------------------------------------------------------------------------------------------


namespace RoboDk.API.Model;

/// <summary>
///  Projection types (for AddCurve)
/// </summary>
public enum ProjectionType
{
    /// <summary>
    /// No curve projection.
    /// </summary>
    None = 0,

    /// <summary>
    /// The projection will the closest point on the surface.
    /// </summary>
    Closest = 1,

    /// <summary>
    /// The projection will be done along the normal.
    /// </summary>
    AlongNormal = 2,

    /// <summary>
    /// The projection will be done along the normal. Furthermore, the normal will be recalculated according to the surface normal.
    /// </summary>
    AlongNormalRecalc = 3,

    /// <summary>
    /// The projection will be the closest point on the surface and the normals will be recalculated.
    /// </summary>
    ClosesRecalcNormal = 4,

    /// <summary>
    /// The normals are recalculated according to the surface normal of the closest projection. The points are not changed.
    /// </summary>
    RecalcNormal = 5
}