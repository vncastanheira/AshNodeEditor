//////////////////////////////////////
//// FILE GENERATED AUTOMATICALLY ////
//////////////////////////////////////

using Ashkatchap.AIBrain.Nodes;
using System;

namespace Ashkatchap.AIBrain.GeneratedNodes {
	[Serializable]
	[CreateNode("Actuator/UnityEngine/Color/op_Division (Color a, Single b) : Color")]
	public class GN_UnityEngine_Color_op_Division_0929FE46643E9F83D0A00C1BE7B85771 : Node {
		[HideInNormalInspector] [UnityEngine.SerializeField] public Input_UnityEngine_Color a;
		[HideInNormalInspector] [UnityEngine.SerializeField] public Input_System_Single b;

		[HideInNormalInspector] [UnityEngine.SerializeField] public Output_UnityEngine_Color returnVar;


#if UNITY_EDITOR
		public override void Init() {
			SetName("/");
			a = CreateIO<Input_UnityEngine_Color>();
			b = CreateIO<Input_System_Single>();
			returnVar = CreateIO<Output_UnityEngine_Color>();
		}
#endif

		public override NodeTreeOutput Tick(out ExecutionResult executionResult, ExecutionResult childResult) {
			Calculate();
			executionResult = ExecutionResult.Success;
			return null;
		}

		public override void Calculate() {
			returnVar.value = (a.GetValue() / b.GetValue());
		}

#if UNITY_EDITOR
		protected override void Draw() {
			a.DisplayLayout("a");
			b.DisplayLayout("b");
			returnVar.DisplayLayout("Return");
		}
#endif
	}
}
