// ----------------------------------------------------------------------------------------------------------
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
/// Euler type
/// </summary>
public enum EulerType
{
    /// <summary>
    /// joints 
    /// </summary>
    JointFormat = -1,

    /// <summary>
    /// generic
    /// </summary>
    EulerRxRypRzpp = 0,

    /// <summary>
    /// ABB RobotStudio
    /// </summary>
    EulerRzRypRxpp = 1,

    /// <summary>
    /// Kawasaki, Adept, Staubli
    /// </summary>
    EulerRzRypRzpp = 2,

    /// <summary>
    /// CATIA, SolidWorks
    /// </summary>
    EulerRzRxpRzpp = 3,

    /// <summary>
    /// Fanuc, Kuka, Motoman, Nachi
    /// </summary>
    EulerRxRyRz = 4,

    /// <summary>
    /// CRS
    /// </summary>
    EulerRzRyRx = 5,

    /// <summary>
    /// ABB Rapid
    /// </summary>
    EulerQueaternion = 6
}