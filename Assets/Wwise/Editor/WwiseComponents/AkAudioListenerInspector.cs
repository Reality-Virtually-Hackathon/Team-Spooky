<<<<<<< HEAD
﻿#if UNITY_EDITOR
//////////////////////////////////////////////////////////////////////
//
// Copyright (c) 2017 Audiokinetic Inc. / All Rights Reserved
//
//////////////////////////////////////////////////////////////////////

using UnityEngine;
using UnityEditor;
using System;

[CanEditMultipleObjects]
[CustomEditor(typeof(AkAudioListener))]
public class AkAudioListenerInspector : Editor
{
	SerializedProperty m_isDefaultListener;

	void OnEnable()
	{
		m_isDefaultListener = serializedObject.FindProperty("isDefaultListener");
	}

	public override void OnInspectorGUI()
	{
		GUILayout.BeginVertical("Box");
		{
			EditorGUI.BeginChangeCheck();
			EditorGUILayout.PropertyField(m_isDefaultListener);
			if (EditorGUI.EndChangeCheck())
				serializedObject.ApplyModifiedProperties();
		}
		GUILayout.EndVertical();
	}
}
#endif
=======
﻿#if UNITY_EDITOR
//////////////////////////////////////////////////////////////////////
//
// Copyright (c) 2017 Audiokinetic Inc. / All Rights Reserved
//
//////////////////////////////////////////////////////////////////////

using UnityEngine;
using UnityEditor;
using System;

[CanEditMultipleObjects]
[CustomEditor(typeof(AkAudioListener))]
public class AkAudioListenerInspector : Editor
{
	SerializedProperty m_isDefaultListener;

	void OnEnable()
	{
		m_isDefaultListener = serializedObject.FindProperty("isDefaultListener");
	}

	public override void OnInspectorGUI()
	{
		GUILayout.BeginVertical("Box");
		{
			EditorGUI.BeginChangeCheck();
			EditorGUILayout.PropertyField(m_isDefaultListener);
			if (EditorGUI.EndChangeCheck())
				serializedObject.ApplyModifiedProperties();
		}
		GUILayout.EndVertical();
	}
}
#endif
>>>>>>> 037ece321dd729b057afc3d6223a342aa14e8428
