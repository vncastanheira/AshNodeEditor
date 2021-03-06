//////////////////////////////////////
//// FILE GENERATED AUTOMATICALLY ////
//////////////////////////////////////

using Ashkatchap.AIBrain.Nodes;
using System;

namespace Ashkatchap.AIBrain.GeneratedNodes {
	[Serializable]
	[CreateNode("Actuator/UnityEngine/Object/op_Inequality (Object x, Object y) : Boolean")]
	public class GN_UnityEngine_Object_op_Inequality_8DA0677733A6A0D07D1226161A4A4BB0 : Node {
		[HideInNormalInspector] [UnityEngine.SerializeField] public Input_UnityEngine_Object x;
		[HideInNormalInspector] [UnityEngine.SerializeField] public Input_UnityEngine_Object y;

		[HideInNormalInspector] [UnityEngine.SerializeField] public Output_System_Boolean returnVar;


#if UNITY_EDITOR
		public override void Init() {
			SetName("!=");
			x = CreateInput<Input_UnityEngine_Object, UnityEngine.Object>(new UnityEngine.Object());
			y = CreateInput<Input_UnityEngine_Object, UnityEngine.Object>(new UnityEngine.Object());
			returnVar = CreateIO<Output_System_Boolean>();
		}
#endif

		public override NodeTreeOutput Tick(out ExecutionResult executionResult, ExecutionResult childResult) {
			Calculate();
			executionResult = ExecutionResult.Success;
			return null;
		}

		public override void Calculate() {
			returnVar.value = (x.GetValue() != y.GetValue());
		}

#if UNITY_EDITOR
		protected override void Draw() {
			x.DisplayLayout("x");
			y.DisplayLayout("y");
			returnVar.DisplayLayout("Return");
		}
#endif
	}
}
