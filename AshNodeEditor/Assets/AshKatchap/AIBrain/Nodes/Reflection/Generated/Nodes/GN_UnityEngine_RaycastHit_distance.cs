//////////////////////////////////////
//// FILE GENERATED AUTOMATICALLY ////
//////////////////////////////////////

using Ashkatchap.AIBrain.Nodes;
using System;

namespace Ashkatchap.AIBrain.GeneratedNodes {
	[Serializable]
	[CreateNode("Actuator/UnityEngine/RaycastHit/distance")]
	public class GN_UnityEngine_RaycastHit_distance : Node {
		[HideInNormalInspector] [UnityEngine.SerializeField] public Input_UnityEngine_RaycastHit refObject;
		[HideInNormalInspector] [UnityEngine.SerializeField] public Output_System_Single getter;


#if UNITY_EDITOR
		public override void Init() {
			SetName("distance");
			refObject = CreateIO<Input_UnityEngine_RaycastHit>();
			getter = CreateIO<Output_System_Single>();
		}
#endif

		public override NodeTreeOutput Tick(out ExecutionResult executionResult, ExecutionResult childResult) {
			executionResult = ExecutionResult.Success;
			return null;
		}

		public override void Calculate() {
			getter.value = (((UnityEngine.RaycastHit) refObject.GetValue()).distance);
		}

#if UNITY_EDITOR
		protected override void Draw() {
			refObject.DisplayLayout("Reference");
			UnityEngine.GUILayout.BeginHorizontal();
			getter.DisplayLayout("get distance");
			UnityEngine.GUILayout.EndHorizontal();
		}
#endif
	}
}
