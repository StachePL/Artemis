﻿using System;
using Artemis.Models.Interfaces;
using MoonSharp.Interpreter;

namespace Artemis.Profiles.Lua.Events
{
    [MoonSharpUserData]
    public class LuaDeviceDrawingEventArgs : EventArgs
    {
        public LuaDeviceDrawingEventArgs(string deviceType, IDataModel dataModel, bool preview, LuaDrawWrapper luaDrawWrapper)
        {
            DeviceType = deviceType;
            DataModel = dataModel;
            Preview = preview;
            Drawing = luaDrawWrapper;
        }

        public string DeviceType { get; set; }
        public IDataModel DataModel { get; }
        public bool Preview { get; }
        public LuaDrawWrapper Drawing { get; set; }
    }
}