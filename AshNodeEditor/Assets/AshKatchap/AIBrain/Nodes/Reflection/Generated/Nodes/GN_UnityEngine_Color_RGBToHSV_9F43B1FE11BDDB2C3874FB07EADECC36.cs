//////////////////////////////////////
//// FILE GENERATED AUTOMATICALLY ////
//////////////////////////////////////

using Ashkatchap.AIBrain.Nodes;
using System;

namespace Ashkatchap.AIBrain.GeneratedNodes {
	[Serializable]
	[CreateNode("Actuator/UnityEngine/Color/RGBToHSV (Color rgbColor, out Single H, out Single S, out Single V) : Void")]
	public class GN_UnityEngine_Color_RGBToHSV_9F43B1FE11BDDB2C3874FB07EADECC36 : Node {
		[HideInNormalInspector] [UnityEngine.SerializeField] public Input_UnityEngine_Color rgbColor;
		[HideInNormalInspector] [UnityEngine.SerializeField] public Output_System_Single H;
		[HideInNormalInspector] [UnityEngine.SerializeField] public Output_System_Single S;
		[HideInNormalInspector] [UnityEngine.SerializeField] public Output_System_Single V;


#if UNITY_EDITOR
		public override void Init() {
			SetName("RGBToHSV");
			rgbColor = CreateIO<Input_UnityEngine_Color>();
			H = CreateIO<Output_System_Single>();
			S = CreateIO<Output_System_Single>();
			V = CreateIO<Output_System_Single>();
		}
#endif

		public override NodeTreeOutput Tick(out ExecutionResult executionResult, ExecutionResult childResult) {
			Calculate();
			executionResult = ExecutionResult.Success;
			return null;
		}

		public override void Calculate() {
			System.Single out_H;
			System.Single out_S;
			System.Single out_V;
			UnityEngine.Color.RGBToHSV(rgbColor.GetValue(), out out_H, out out_S, out out_V);
			H.value = (out_H);
			S.value = (out_S);
			V.value = (out_V);
		}

#if UNITY_EDITOR
		protected override void Draw() {
			rgbColor.DisplayLayout("rgbColor");
			H.DisplayLayout("H");
			S.DisplayLayout("S");
			V.DisplayLayout("V");
		}
#endif
	}
}
