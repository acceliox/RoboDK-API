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
/// Type of information returned by InstructionListJoints and GetInstructionListJoints
/// </summary>
public enum SetJointsType
{
    /// <summary>
    /// Default behavior, will saturate the joints and apply the result. This option is used to support older versions of RoboDK.
    /// </summary>
    Default = 0,

    /// <summary>
    /// setJoints will apply the robot joints in any case. The robot may be displayed in an invalid solution: robot panel values and sliders will not show the correct robot position.
    /// </summary>
    Always = 1,

    /// <summary>
    /// Will ignore setting robot joints if the joints are invalid (outside joint limits). This is the same as the default behavior with accurate return of saturation state.
    /// </summary>
    SaturateIgnore = 2,

    /// <summary>
    /// Will saturate the robot joints and apply the closest robot joitns solution.
    /// </summary>
    SaturateApply = 3
}