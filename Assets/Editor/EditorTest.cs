
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using NUnit.Framework;

/// <summary>
/// Test GetRawTextureData
/// https://docs.unity3d.com/ScriptReference/Texture2D.GetRawTextureData.html
/// </summary>
public class Texture2DTest
{
    [Test]
    public void TestColor32()
    {
        var tex = new Texture2D(256, 256, TextureFormat.RGBA32, false);

        var pixelsManaged = tex.GetPixels32();
        var pixelsNative = tex.GetRawTextureData<Color32>();
        
        Assert.AreEqual(pixelsManaged.Length, pixelsNative.Length);
    }

    [Test]
    public void TestBytes()
    {
        var tex = new Texture2D(256, 256, TextureFormat.RGBA32, false);

        var pixelsManaged = tex.GetPixels32();
        var pixelsBytes = tex.GetRawTextureData();

        Assert.AreEqual(pixelsManaged.Length * 4, pixelsBytes.Length);
    }


    [Test]
    public void TestColor32WithLinerOption()
    {
        var tex = new Texture2D(256, 256, TextureFormat.RGBA32, 0, true);

        var pixelsManaged = tex.GetPixels32();
        var pixelsNative = tex.GetRawTextureData<Color32>();

        Assert.AreEqual(pixelsManaged.Length, pixelsNative.Length);
    }

    [Test]
    public void TestByteWithLinerOption()
    {
        var tex = new Texture2D(256, 256, TextureFormat.RGBA32, 0, true);

        var pixelsManaged = tex.GetPixels32();
        var pixelsBytes = tex.GetRawTextureData();

        Assert.AreEqual(pixelsManaged.Length * 4, pixelsBytes.Length);
    }
}

