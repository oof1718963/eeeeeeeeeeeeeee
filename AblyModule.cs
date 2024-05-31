﻿// Decompiled with JetBrains decompiler
// Type: ClassroomWindows.AblyModule
// Assembly: ClassroomWindows, Version=3.4.7.6, Culture=neutral, PublicKeyToken=null
// MVID: 59349F94-FAF6-4BCE-A4AE-E4F9DD746CAB
// Assembly location: C:\Users\Karim\Downloads\ClassroomWindows.exe

using NLog;
using System.ComponentModel;

#nullable disable
namespace ClassroomWindows
{
  internal class AblyModule : IModule
  {
    private static AblyModule s_instance = (AblyModule) null;
    private static readonly object LOCK = new object();
    private static readonly Logger logger = LogManager.GetCurrentClassLogger();
    private double _stateTime;

    public static AblyModule Instance
    {
      get
      {
        lock (AblyModule.LOCK)
        {
          if (AblyModule.s_instance == null)
            AblyModule.s_instance = new AblyModule();
          return AblyModule.s_instance;
        }
      }
    }

    private AblyModule()
    {
    }

    public void Update(BackgroundWorker bgw, double deltaTime)
    {
      this._stateTime += deltaTime;
      if (this._stateTime < 0.5)
        return;
      this._stateTime = 0.0;
      AblyConnectionManager.Instance.Update(deltaTime);
    }
  }
}
