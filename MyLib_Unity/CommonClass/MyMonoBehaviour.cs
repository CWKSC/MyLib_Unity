﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMonoBehaviour : MonoBehaviour
{


    public T _<T>() => GetComponent<T>();

    public T1 _<T1>(ref T1 t1) => t1 = _<T1>();

    public void _<T1, T2>(ref T1 t1, ref T2 t2)
    {
        _(ref t1);
        _(ref t2);
    }
    public void _<T1, T2, T3>(ref T1 t1, ref T2 t2, ref T3 t3)
    {
        _(ref t1, ref t2);
        _(ref t3);
    }
    public void _<T1, T2, T3, T4>(ref T1 t1, ref T2 t2, ref T3 t3, ref T4 t4)
    {
        _(ref t1, ref t2, ref t3);
        _(ref t4);
    }
    public void _<T1, T2, T3, T4, T5>(ref T1 t1, ref T2 t2, ref T3 t3, ref T4 t4, ref T5 t5)
    {
        _(ref t1, ref t2, ref t3, ref t4);
        _(ref t5);
    }
    public void _<T1, T2, T3, T4, T5, T6>(ref T1 t1, ref T2 t2, ref T3 t3, ref T4 t4, ref T5 t5, ref T6 t6)
    {
        _(ref t1, ref t2, ref t3, ref t4, ref t5);
        _(ref t6);
    }

    #region Add Component If Not Exits
    public T AddComponentIfNotExits<T>() where T : Component
    {
        Component component = GetComponent<T>();
        if (component == null)
        {
            Debug.Log("GameObject: [" + gameObject.name + "] havn't [" + typeof(T) + "] component, suggest Add it manually.");
            return gameObject.AddComponent<T>();
        }
        return (T)component;
    }
    public T AddComponentIfNotExits_noWarning<T>() where T : Component
    {
        Component component = GetComponent<T>();
        return component == null ? gameObject.AddComponent<T>() : (T)component;
    }

    public static T AddComponentIfNotExits<T>(GameObject gameObject) where T : Component
    {
        Component component = gameObject.GetComponent<T>();
        if (component == null)
        {
            Debug.Log("GameObject: [" + gameObject.name + "] havn't [" + typeof(T) + "] component, suggest Add it manually.");
            return gameObject.AddComponent<T>();
        }
        return (T)component;
    }
    public static T AddComponentIfNotExits_noWarning<T>(GameObject gameObject) where T : Component
    {
        Component component = gameObject.GetComponent<T>();
        return component == null ? gameObject.AddComponent<T>() : (T)component;
    }
    #endregion




}
