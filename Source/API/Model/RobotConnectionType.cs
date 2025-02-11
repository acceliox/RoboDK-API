﻿namespace RoboDk.API.Model;

public enum RobotConnectionType
{
    Unknown = -1000,
    Problems = -3,
    Disconnected = -2,
    NotConnected = -1,
    Ready = 0,
    Working = 1,
    Waiting = 2
}