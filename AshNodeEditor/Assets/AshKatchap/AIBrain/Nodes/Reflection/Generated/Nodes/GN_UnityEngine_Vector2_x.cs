//////////////////////////////////////
//// FILE GENERATED AUTOMATICALLY ////
//////////////////////////////////////

using System;
using Ashkatchap.AIBrain.Nodes;

namespace Ashkatchap.AIBrain.GeneratedNodes {
	[Serializable]
	[CreateNode("Actuator/UnityEngine/Vector2/x")]
	public class GN_UnityEngine_Vector2_x : Node {
		[HideInNormalInspector] [UnityEngine.SerializeField] public Input_UnityEngine_Vector2 refObject;
		[HideInNormalInspector] [UnityEngine.SerializeField] public Output_System_Single getter;


#if UNITY_EDITOR
		public override void Init() {
			SetName("x");
			refObject = CreateIO<Input_UnityEngine_Vector2>();
			getter = CreateIO<Output_System_Single>();
		}
#endif

		public override NodeTreeOutput Tick(out ExecutionResult executionResult, ExecutionResult childResult) {
			executionResult = ExecutionResult.Success;
			return null;
		}

		public override void Calculate() {
				getter.SetValue(((UnityEngine.Vector2) refObject.GetValue()).x);
		}

#if UNITY_EDITOR
		protected override void Draw() {
			refObject.DisplayLayout("Reference");
			UnityEngine.GUILayout.BeginHorizontal();
			getter.DisplayLayout("get x");
			UnityEngine.GUILayout.EndHorizontal();
		}
#endif
	}
}