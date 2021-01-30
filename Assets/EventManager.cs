﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void Del_Void();
    public delegate void Del_Void_GameObject(GameObject gameObject);

    //public Del_Void Evt_SliceMesh = delegate { };
    public Del_Void_GameObject Evt_InitVolume = delegate { };
    //public Del_Void_GameObject Evt_OnSliceMesh = delegate { };
    public Del_Void_GameObject Evt_OnSwitchSliceMesh = delegate { };



    public static EventManager Get(GameObject gameobject)
    {
        return gameobject.GetComponent<EventManager>();
    }
}