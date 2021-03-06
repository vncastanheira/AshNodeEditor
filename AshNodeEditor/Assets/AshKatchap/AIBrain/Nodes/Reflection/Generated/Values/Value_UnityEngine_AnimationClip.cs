//////////////////////////////////////
//// FILE GENERATED AUTOMATICALLY ////
//////////////////////////////////////

using Ashkatchap.AIBrain.Nodes;
using System;

namespace Ashkatchap.AIBrain.GeneratedNodes {
	[Serializable]
	[CreateNode("Values/UnityEngine/AnimationClip")]
	public class Value_UnityEngine_AnimationClip : ValueBase<UnityEngine.AnimationClip> {
		public Input_UnityEngine_AnimationClip valueInput;
		public Output_UnityEngine_AnimationClip valueOutput;

#if UNITY_EDITOR
		public override void Init() {
			SetName("AnimationClip");
			valueOutput = CreateIO<Output_UnityEngine_AnimationClip>();
			valueInput = CreateIO<Input_UnityEngine_AnimationClip>();
		}
#endif

		public override void Calculate() {
			valueOutput.value = value;
		}

		public override NodeInput GetInput() { return valueInput; }
		public override NodeOutput GetOutput() { return valueOutput; }
	}
}
