<<<<<<< HEAD
#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
//////////////////////////////////////////////////////////////////////
//
// Copyright (c) 2014 Audiokinetic Inc. / All Rights Reserved
//
//////////////////////////////////////////////////////////////////////

using UnityEngine;

[System.Serializable]
public class AkGameObjPositionOffsetData
{
    public Vector3 positionOffset;
    public bool KeepMe = false;

	// Unity tries to construct a AkGameObjPositionOffsetData all the time. Need this ugly workaround
	// to prevent it from doing this.
    public AkGameObjPositionOffsetData(bool IReallyWantToBeConstructed = false)
    {
        KeepMe = IReallyWantToBeConstructed;
    }
}

=======
#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
//////////////////////////////////////////////////////////////////////
//
// Copyright (c) 2014 Audiokinetic Inc. / All Rights Reserved
//
//////////////////////////////////////////////////////////////////////

using UnityEngine;

[System.Serializable]
public class AkGameObjPositionOffsetData
{
    public Vector3 positionOffset;
    public bool KeepMe = false;

	// Unity tries to construct a AkGameObjPositionOffsetData all the time. Need this ugly workaround
	// to prevent it from doing this.
    public AkGameObjPositionOffsetData(bool IReallyWantToBeConstructed = false)
    {
        KeepMe = IReallyWantToBeConstructed;
    }
}

>>>>>>> 037ece321dd729b057afc3d6223a342aa14e8428
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.