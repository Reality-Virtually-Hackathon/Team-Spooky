<<<<<<< HEAD
#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class AkChannelEmitterEx : AkChannelEmitter {
  private IntPtr swigCPtr;

  internal AkChannelEmitterEx(IntPtr cPtr, bool cMemoryOwn) : base(AkSoundEnginePINVOKE.CSharp_AkChannelEmitterEx_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = cPtr;
  }

  internal static IntPtr getCPtr(AkChannelEmitterEx obj) {
    return (obj == null) ? IntPtr.Zero : obj.swigCPtr;
  }

  ~AkChannelEmitterEx() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkChannelEmitterEx(swigCPtr);
        }
        swigCPtr = IntPtr.Zero;
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public AkChannelEmitterEx() : this(AkSoundEnginePINVOKE.CSharp_new_AkChannelEmitterEx(), true) {
  }

  public float occlusion {
    set {
      AkSoundEnginePINVOKE.CSharp_AkChannelEmitterEx_occlusion_set(swigCPtr, value);
    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkChannelEmitterEx_occlusion_get(swigCPtr);
      return ret;
    } 
  }

  public float obstruction {
    set {
      AkSoundEnginePINVOKE.CSharp_AkChannelEmitterEx_obstruction_set(swigCPtr, value);
    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkChannelEmitterEx_obstruction_get(swigCPtr);
      return ret;
    } 
  }

}
=======
#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class AkChannelEmitterEx : AkChannelEmitter {
  private IntPtr swigCPtr;

  internal AkChannelEmitterEx(IntPtr cPtr, bool cMemoryOwn) : base(AkSoundEnginePINVOKE.CSharp_AkChannelEmitterEx_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = cPtr;
  }

  internal static IntPtr getCPtr(AkChannelEmitterEx obj) {
    return (obj == null) ? IntPtr.Zero : obj.swigCPtr;
  }

  ~AkChannelEmitterEx() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkChannelEmitterEx(swigCPtr);
        }
        swigCPtr = IntPtr.Zero;
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public AkChannelEmitterEx() : this(AkSoundEnginePINVOKE.CSharp_new_AkChannelEmitterEx(), true) {
  }

  public float occlusion {
    set {
      AkSoundEnginePINVOKE.CSharp_AkChannelEmitterEx_occlusion_set(swigCPtr, value);
    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkChannelEmitterEx_occlusion_get(swigCPtr);
      return ret;
    } 
  }

  public float obstruction {
    set {
      AkSoundEnginePINVOKE.CSharp_AkChannelEmitterEx_obstruction_set(swigCPtr, value);
    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkChannelEmitterEx_obstruction_get(swigCPtr);
      return ret;
    } 
  }

}
>>>>>>> 037ece321dd729b057afc3d6223a342aa14e8428
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.