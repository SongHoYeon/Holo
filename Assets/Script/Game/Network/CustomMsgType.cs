﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;

public class CustomMsgType  {

    public static short Receive_Connect = MsgType.Highest + 1;
    public static short Send_LensIdx = MsgType.Highest + 2;
    public static short Receive_ControllerMove = MsgType.Highest + 3;
}

namespace UnityEngine.Networking.NetworkSystem
{
    public class Receive_Connect_Message : MessageBase
    {
        // 1: Lens , 2: Controller
        public int id;
        public int connectionId;
    }

    public class Send_LensIdx_Message : MessageBase
    {
        // Start as 0
        public int idx;
    }

    public class Receive_ControllerMove_Message : MessageBase
    {
        // TargetLens Idx
        public int targetIdx;
        // 0 : left , 1 : right , 2 : confirm , 3 : cancel
        public int input;

    }
}