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

public class AkObstructionOcclusionValues : IDisposable {
  private IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal AkObstructionOcclusionValues(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static IntPtr getCPtr(AkObstructionOcclusionValues obj) {
    return (obj == null) ? IntPtr.Zero : obj.swigCPtr;
  }

  ~AkObstructionOcclusionValues() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkObstructionOcclusionValues(swigCPtr);
        }
        swigCPtr = IntPtr.Zero;
      }
      GC.SuppressFinalize(this);
    }
  }

  public float occlusion {
    set {
      AkSoundEnginePINVOKE.CSharp_AkObstructionOcclusionValues_occlusion_set(swigCPtr, value);
    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkObstructionOcclusionValues_occlusion_get(swigCPtr);
      return ret;
    } 
  }

  public float obstruction {
    set {
      AkSoundEnginePINVOKE.CSharp_AkObstructionOcclusionValues_obstruction_set(swigCPtr, value);
    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkObstructionOcclusionValues_obstruction_get(swigCPtr);
      return ret;
    } 
  }

  public AkObstructionOcclusionValues() : this(AkSoundEnginePINVOKE.CSharp_new_AkObstructionOcclusionValues(), true) {

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

public class AkObstructionOcclusionValues : IDisposable {
  private IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal AkObstructionOcclusionValues(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static IntPtr getCPtr(AkObstructionOcclusionValues obj) {
    return (obj == null) ? IntPtr.Zero : obj.swigCPtr;
  }

  ~AkObstructionOcclusionValues() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkObstructionOcclusionValues(swigCPtr);
        }
        swigCPtr = IntPtr.Zero;
      }
      GC.SuppressFinalize(this);
    }
  }

  public float occlusion {
    set {
      AkSoundEnginePINVOKE.CSharp_AkObstructionOcclusionValues_occlusion_set(swigCPtr, value);
    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkObstructionOcclusionValues_occlusion_get(swigCPtr);
      return ret;
    } 
  }

  public float obstruction {
    set {
      AkSoundEnginePINVOKE.CSharp_AkObstructionOcclusionValues_obstruction_set(swigCPtr, value);
    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkObstructionOcclusionValues_obstruction_get(swigCPtr);
      return ret;
    } 
  }

  public AkObstructionOcclusionValues() : this(AkSoundEnginePINVOKE.CSharp_new_AkObstructionOcclusionValues(), true) {

  }

}
>>>>>>> 037ece321dd729b057afc3d6223a342aa14e8428
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.