﻿using UnityEngine;
using System.Collections.Generic;
using System;
using Ashkatchap.AIBrain.Nodes;
using Ashkatchap.Shared;
using UnityEditor;

namespace Ashkatchap.AIBrain {
	[CustomEditor(typeof(Context))]
	public class ContextEditor : Editor {
		public override void OnInspectorGUI() {
			//DrawDefaultInspector();

			Context myTarget = (Context) target;
			if (GUILayout.Button("Open")) {
				Node_Editor_GUI editor = CreateInstance<Node_Editor_GUI>();
				editor.nodeCanvas = myTarget;
				editor.Show();
			}
		}
	}
}
