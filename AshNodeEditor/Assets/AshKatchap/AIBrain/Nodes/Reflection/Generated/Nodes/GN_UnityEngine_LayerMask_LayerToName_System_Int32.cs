//////////////////////////////////////
//// FILE GENERATED AUTOMATICALLY ////
//////////////////////////////////////

using System;
using Ashkatchap.AIBrain.Nodes;

namespace Ashkatchap.AIBrain.GeneratedNodes {
	[Serializable]
	[CreateNode("Actuator/UnityEngine/LayerMask/LayerToName (Int32 layer) : String")]
	public class GN_UnityEngine_LayerMask_LayerToName_System_Int32 : Node {
		[HideInNormalInspector] [UnityEngine.SerializeField] public Input_System_Int32 layer;

		[HideInNormalInspector] [UnityEngine.SerializeField] public Output_System_String returnVar;


#if UNITY_EDITOR
		public override void Init() {
			SetName("LayerToName");
			layer = CreateIO<Input_System_Int32>();
			returnVar = CreateIO<Output_System_String>();
		}
#endif

		public override NodeTreeOutput Tick(out ExecutionResult executionResult, ExecutionResult childResult) {
			Calculate();
			executionResult = ExecutionResult.Success;
			return null;
		}

		public override void Calculate() {
			returnVar.SetValue(UnityEngine.LayerMask.LayerToName(layer.GetValue()));
		}

#if UNITY_EDITOR
		protected override void Draw() {
			layer.DisplayLayout("layer");
			returnVar.DisplayLayout("Return");
		}
#endif
	}
}