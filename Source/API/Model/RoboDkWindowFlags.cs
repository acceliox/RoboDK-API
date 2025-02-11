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

using System;

namespace RoboDk.API.Model;

/// <summary>
/// RoboDK Window Flags
/// </summary>
[Flags]
public enum WindowFlags
{
    TreeActive = 1, // Enable the tree
    View3DActive = 2, // Enable the 3D view (3D mouse navigation)
    LeftClick = 4, // Enable left clicks
    RightClick = 8, // Enable right clicks
    DoubleClick = 16, // Enable double clicks
    MenuActive = 32, // Enable the main menu (complete menu)
    MenuFileActive = 64, // Enable the File menu
    MenuEditActive = 128, // Enable the Edit menu
    MenuProgramActive = 256, // Enable the Program menu
    MenuToolsActive = 512, // Enable the Tools menu
    MenuUtilitiesActive = 1024, // Enable the Utilities menu
    MenuConnectActive = 2048, // Enable the Connect menu
    WindowKeysActive = 4096, // Enable the keyboard
    TreeVisible = 8192, // Make the station tree visible
    ReferencesVisible = 16384, // Make the reference frames visible
    None = 0, //  Disable everything
    All = 0xFFFF, // Enable everything

    MenuActiveAll = MenuActive | MenuFileActive | MenuEditActive | MenuProgramActive |
                    MenuToolsActive | MenuUtilitiesActive | MenuConnectActive
}