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

public class AkPlaylistArray : IDisposable {
  private IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal AkPlaylistArray(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static IntPtr getCPtr(AkPlaylistArray obj) {
    return (obj == null) ? IntPtr.Zero : obj.swigCPtr;
  }

  ~AkPlaylistArray() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkPlaylistArray(swigCPtr);
        }
        swigCPtr = IntPtr.Zero;
      }
      GC.SuppressFinalize(this);
    }
  }

  public AkPlaylistArray() : this(AkSoundEnginePINVOKE.CSharp_new_AkPlaylistArray(), true) {

  }

  public Iterator Begin() {
    Iterator ret = new Iterator(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Begin(swigCPtr), true);

    return ret;
  }

  public Iterator End() {
    Iterator ret = new Iterator(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_End(swigCPtr), true);

    return ret;
  }

  public Iterator FindEx(PlaylistItem in_Item) {
    Iterator ret = new Iterator(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_FindEx(swigCPtr, PlaylistItem.getCPtr(in_Item)), true);

    return ret;
  }

  public Iterator Erase(Iterator in_rIter) {
    Iterator ret = new Iterator(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Erase__SWIG_0(swigCPtr, Iterator.getCPtr(in_rIter)), true);

    return ret;
  }

  public void Erase(uint in_uIndex) {
    AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Erase__SWIG_1(swigCPtr, in_uIndex);

  }

  public Iterator EraseSwap(Iterator in_rIter) {
    Iterator ret = new Iterator(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_EraseSwap(swigCPtr, Iterator.getCPtr(in_rIter)), true);

    return ret;
  }

  public AKRESULT Reserve(uint in_ulReserve) {
    AKRESULT ret = (AKRESULT)AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Reserve(swigCPtr, in_ulReserve);

    return ret;
  }

  public uint Reserved() {
    uint ret = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Reserved(swigCPtr);

    return ret;
  }

  public void Term() {
    AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Term(swigCPtr);

  }

  public uint Length() {
    uint ret = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Length(swigCPtr);

    return ret;
  }

  public bool IsEmpty() {
    bool ret = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_IsEmpty(swigCPtr);

    return ret;
  }

  public PlaylistItem Exists(PlaylistItem in_Item) {
    IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Exists(swigCPtr, PlaylistItem.getCPtr(in_Item));
    PlaylistItem ret = (cPtr == IntPtr.Zero) ? null : new PlaylistItem(cPtr, false);

    return ret;
  }

  public PlaylistItem AddLast() {
    IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_AddLast__SWIG_0(swigCPtr);
    PlaylistItem ret = (cPtr == IntPtr.Zero) ? null : new PlaylistItem(cPtr, false);

    return ret;
  }

  public PlaylistItem AddLast(PlaylistItem in_rItem) {
    IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_AddLast__SWIG_1(swigCPtr, PlaylistItem.getCPtr(in_rItem));
    PlaylistItem ret = (cPtr == IntPtr.Zero) ? null : new PlaylistItem(cPtr, false);

    return ret;
  }

  public PlaylistItem Last() {
    PlaylistItem ret = new PlaylistItem(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Last(swigCPtr), false);

    return ret;
  }

  public void RemoveLast() {
    AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_RemoveLast(swigCPtr);

  }

  public AKRESULT Remove(PlaylistItem in_rItem) {
    AKRESULT ret = (AKRESULT)AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Remove(swigCPtr, PlaylistItem.getCPtr(in_rItem));

    return ret;
  }

  public AKRESULT RemoveSwap(PlaylistItem in_rItem) {
    AKRESULT ret = (AKRESULT)AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_RemoveSwap(swigCPtr, PlaylistItem.getCPtr(in_rItem));

    return ret;
  }

  public void RemoveAll() {
    AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_RemoveAll(swigCPtr);

  }

  public PlaylistItem ItemAtIndex(uint uiIndex) {
    PlaylistItem ret = new PlaylistItem(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_ItemAtIndex(swigCPtr, uiIndex), false);

    return ret;
  }

  public PlaylistItem Insert(uint in_uIndex) {
    IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Insert(swigCPtr, in_uIndex);
    PlaylistItem ret = (cPtr == IntPtr.Zero) ? null : new PlaylistItem(cPtr, false);

    return ret;
  }

  public bool GrowArray(uint in_uGrowBy) {
    bool ret = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_GrowArray__SWIG_0(swigCPtr, in_uGrowBy);

    return ret;
  }

  public bool GrowArray() {
    bool ret = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_GrowArray__SWIG_1(swigCPtr);

    return ret;
  }

  public bool Resize(uint in_uiSize) {
    bool ret = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Resize(swigCPtr, in_uiSize);

    return ret;
  }

  public void Transfer(AkPlaylistArray in_rSource) {
    AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Transfer(swigCPtr, AkPlaylistArray.getCPtr(in_rSource));

  }

  public AKRESULT Copy(AkPlaylistArray in_rSource) {
    AKRESULT ret = (AKRESULT)AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Copy(swigCPtr, AkPlaylistArray.getCPtr(in_rSource));

    return ret;
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

public class AkPlaylistArray : IDisposable {
  private IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal AkPlaylistArray(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static IntPtr getCPtr(AkPlaylistArray obj) {
    return (obj == null) ? IntPtr.Zero : obj.swigCPtr;
  }

  ~AkPlaylistArray() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkPlaylistArray(swigCPtr);
        }
        swigCPtr = IntPtr.Zero;
      }
      GC.SuppressFinalize(this);
    }
  }

  public AkPlaylistArray() : this(AkSoundEnginePINVOKE.CSharp_new_AkPlaylistArray(), true) {

  }

  public Iterator Begin() {
    Iterator ret = new Iterator(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Begin(swigCPtr), true);

    return ret;
  }

  public Iterator End() {
    Iterator ret = new Iterator(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_End(swigCPtr), true);

    return ret;
  }

  public Iterator FindEx(PlaylistItem in_Item) {
    Iterator ret = new Iterator(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_FindEx(swigCPtr, PlaylistItem.getCPtr(in_Item)), true);

    return ret;
  }

  public Iterator Erase(Iterator in_rIter) {
    Iterator ret = new Iterator(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Erase__SWIG_0(swigCPtr, Iterator.getCPtr(in_rIter)), true);

    return ret;
  }

  public void Erase(uint in_uIndex) {
    AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Erase__SWIG_1(swigCPtr, in_uIndex);

  }

  public Iterator EraseSwap(Iterator in_rIter) {
    Iterator ret = new Iterator(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_EraseSwap(swigCPtr, Iterator.getCPtr(in_rIter)), true);

    return ret;
  }

  public AKRESULT Reserve(uint in_ulReserve) {
    AKRESULT ret = (AKRESULT)AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Reserve(swigCPtr, in_ulReserve);

    return ret;
  }

  public uint Reserved() {
    uint ret = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Reserved(swigCPtr);

    return ret;
  }

  public void Term() {
    AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Term(swigCPtr);

  }

  public uint Length() {
    uint ret = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Length(swigCPtr);

    return ret;
  }

  public bool IsEmpty() {
    bool ret = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_IsEmpty(swigCPtr);

    return ret;
  }

  public PlaylistItem Exists(PlaylistItem in_Item) {
    IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Exists(swigCPtr, PlaylistItem.getCPtr(in_Item));
    PlaylistItem ret = (cPtr == IntPtr.Zero) ? null : new PlaylistItem(cPtr, false);

    return ret;
  }

  public PlaylistItem AddLast() {
    IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_AddLast__SWIG_0(swigCPtr);
    PlaylistItem ret = (cPtr == IntPtr.Zero) ? null : new PlaylistItem(cPtr, false);

    return ret;
  }

  public PlaylistItem AddLast(PlaylistItem in_rItem) {
    IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_AddLast__SWIG_1(swigCPtr, PlaylistItem.getCPtr(in_rItem));
    PlaylistItem ret = (cPtr == IntPtr.Zero) ? null : new PlaylistItem(cPtr, false);

    return ret;
  }

  public PlaylistItem Last() {
    PlaylistItem ret = new PlaylistItem(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Last(swigCPtr), false);

    return ret;
  }

  public void RemoveLast() {
    AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_RemoveLast(swigCPtr);

  }

  public AKRESULT Remove(PlaylistItem in_rItem) {
    AKRESULT ret = (AKRESULT)AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Remove(swigCPtr, PlaylistItem.getCPtr(in_rItem));

    return ret;
  }

  public AKRESULT RemoveSwap(PlaylistItem in_rItem) {
    AKRESULT ret = (AKRESULT)AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_RemoveSwap(swigCPtr, PlaylistItem.getCPtr(in_rItem));

    return ret;
  }

  public void RemoveAll() {
    AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_RemoveAll(swigCPtr);

  }

  public PlaylistItem ItemAtIndex(uint uiIndex) {
    PlaylistItem ret = new PlaylistItem(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_ItemAtIndex(swigCPtr, uiIndex), false);

    return ret;
  }

  public PlaylistItem Insert(uint in_uIndex) {
    IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Insert(swigCPtr, in_uIndex);
    PlaylistItem ret = (cPtr == IntPtr.Zero) ? null : new PlaylistItem(cPtr, false);

    return ret;
  }

  public bool GrowArray(uint in_uGrowBy) {
    bool ret = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_GrowArray__SWIG_0(swigCPtr, in_uGrowBy);

    return ret;
  }

  public bool GrowArray() {
    bool ret = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_GrowArray__SWIG_1(swigCPtr);

    return ret;
  }

  public bool Resize(uint in_uiSize) {
    bool ret = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Resize(swigCPtr, in_uiSize);

    return ret;
  }

  public void Transfer(AkPlaylistArray in_rSource) {
    AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Transfer(swigCPtr, AkPlaylistArray.getCPtr(in_rSource));

  }

  public AKRESULT Copy(AkPlaylistArray in_rSource) {
    AKRESULT ret = (AKRESULT)AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Copy(swigCPtr, AkPlaylistArray.getCPtr(in_rSource));

    return ret;
  }

}
>>>>>>> 037ece321dd729b057afc3d6223a342aa14e8428
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.