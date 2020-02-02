﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public abstract class GlitchEffect
{
    public static GlitchEffect[] allGlitchEffects;

    public static GlitchEffect GetRandomGlitchEffect ()
    {
        return GlitchEffect.allGlitchEffects[UnityEngine.Random.Range(0, GlitchEffect.allGlitchEffects.Length)];
    }

    public abstract string Description { get; }
    protected abstract void OnCancel();
    public void Cancel()
    {
        OnCancel();
        global::Console.Instance.GetWriter().WriteLine($"<color=#00FFD5><color=#FFCD00>{Description}</color> has been repaired succesfully. The game is now a little less broken.</color>");
    }
    public virtual void WhenCollect() { }
    public virtual  void Update() { }

    [RuntimeInitializeOnLoadMethod]
    public static void Init()
    {
        
        allGlitchEffects = Cyberevolver.TheReflection.GetAllType(item => Cyberevolver.TheReflection.Is(item,typeof(GlitchEffect))&& item != typeof(GlitchEffect))
            .Select(item => (GlitchEffect)Activator.CreateInstance(item))
            .ToArray();
    }

   
}