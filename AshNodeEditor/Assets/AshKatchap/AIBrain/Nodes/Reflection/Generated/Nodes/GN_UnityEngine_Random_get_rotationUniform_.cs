//////////////////////////////////////
//// FILE GENERATED AUTOMATICALLY ////
//////////////////////////////////////

using Ashkatchap.AIBrain.Nodes;
using System;

namespace Ashkatchap.AIBrain.GeneratedNodes {
	[Serializable]
	[CreateNode("Actuator/UnityEngine/Random/get_rotationUniform () : Quaternion")]
	public class GN_UnityEngine_Random_get_rotationUniform_ : Node {

		[HideInNormalInspector] [UnityEngine.SerializeField] public Output_UnityEngine_Quaternion returnVar;


#if UNITY_EDITOR
		public override void Init() {
			SetName("rotationUniform");
			returnVar = CreateIO<Output_UnityEngine_Quaternion>();
		}
#endif

		public override NodeTreeOutput Tick(out ExecutionResult executionResult, ExecutionResult childResult) {
			Calculate();
			executionResult = ExecutionResult.Success;
			return null;
		}

		public override void Calculate() {
			returnVar.value = (UnityEngine.Random.rotationUniform);
		}

#if UNITY_EDITOR
		protected override void Draw() {
			returnVar.DisplayLayout("Return");
		}
#endif
	}
}
