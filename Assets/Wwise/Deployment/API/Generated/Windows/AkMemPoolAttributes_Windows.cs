<<<<<<< HEAD
#if (UNITY_STANDALONE_WIN && !UNITY_EDITOR) || UNITY_EDITOR_WIN
/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public enum AkMemPoolAttributes {
  AkNoAlloc = 0,
  AkMalloc = 1 << 0,
  AkVirtualAlloc = 1 << 1,
  AkAllocMask = AkNoAlloc|AkMalloc|AkVirtualAlloc,
  AkFixedSizeBlocksMode = 1 << 3,
  AkBlockMgmtMask = AkFixedSizeBlocksMode
}
=======
#if (UNITY_STANDALONE_WIN && !UNITY_EDITOR) || UNITY_EDITOR_WIN
/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public enum AkMemPoolAttributes {
  AkNoAlloc = 0,
  AkMalloc = 1 << 0,
  AkVirtualAlloc = 1 << 1,
  AkAllocMask = AkNoAlloc|AkMalloc|AkVirtualAlloc,
  AkFixedSizeBlocksMode = 1 << 3,
  AkBlockMgmtMask = AkFixedSizeBlocksMode
}
>>>>>>> 037ece321dd729b057afc3d6223a342aa14e8428
#endif // #if (UNITY_STANDALONE_WIN && !UNITY_EDITOR) || UNITY_EDITOR_WIN