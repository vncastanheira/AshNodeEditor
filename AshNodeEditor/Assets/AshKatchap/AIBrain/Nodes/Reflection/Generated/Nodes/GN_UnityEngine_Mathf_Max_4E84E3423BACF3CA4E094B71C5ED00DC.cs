//////////////////////////////////////
//// FILE GENERATED AUTOMATICALLY ////
//////////////////////////////////////

using System;
using Ashkatchap.AIBrain.Nodes;

namespace Ashkatchap.AIBrain.GeneratedNodes {
	[Serializable]
	[CreateNode("Actuator/UnityEngine/Mathf/Max (Int32 a, Int32 b) : Int32")]
	public class GN_UnityEngine_Mathf_Max_4E84E3423BACF3CA4E094B71C5ED00DC : Node {
		[HideInNormalInspector] [UnityEngine.SerializeField] public Input_System_Int32 a;
		[HideInNormalInspector] [UnityEngine.SerializeField] public Input_System_Int32 b;

		[HideInNormalInspector] [UnityEngine.SerializeField] public Output_System_Int32 returnVar;


#if UNITY_EDITOR
		public override void Init() {
			SetName("Max");
			a = CreateIO<Input_System_Int32>();
			b = CreateIO<Input_System_Int32>();
			returnVar = CreateIO<Output_System_Int32>();
		}
#endif

		public override NodeTreeOutput Tick(out ExecutionResult executionResult, ExecutionResult childResult) {
			Calculate();
			executionResult = ExecutionResult.Success;
			return null;
		}

		public override void Calculate() {
			returnVar.SetValue(UnityEngine.Mathf.Max(a.GetValue(), b.GetValue()));
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
