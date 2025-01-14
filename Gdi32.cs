﻿
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ClassroomWindows
{
  public class Gdi32
  {
    public const int SRCCOPY = 13369376;

    [DllImport("gdi32.dll")]
    public static extern bool BitBlt(
      IntPtr dest,
      int xDest,
      int yDest,
      int width,
      int height,
      IntPtr source,
      int xSrc,
      int ySrc,
      int rop);

    [DllImport("gdi32.dll")]
    public static extern IntPtr CreateCompatibleBitmap(IntPtr DC, int width, int height);

    [DllImport("gdi32.dll")]
    public static extern IntPtr CreateCompatibleDC(IntPtr DC);

    [DllImport("gdi32.dll")]
    public static extern bool DeleteDC(IntPtr DC);

    [DllImport("gdi32.dll")]
    public static extern bool DeleteObject(IntPtr objectHandle);

    [DllImport("gdi32.dll")]
    public static extern IntPtr SelectObject(IntPtr DC, IntPtr objectHandle);
  }
}
