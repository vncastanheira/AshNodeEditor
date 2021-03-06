//////////////////////////////////////
//// FILE GENERATED AUTOMATICALLY ////
//////////////////////////////////////

using Ashkatchap.AIBrain.Nodes;
using System;

namespace Ashkatchap.AIBrain.GeneratedNodes {
	[Serializable]
	[CreateNode("Values/System/String")]
	public class Value_System_String : ValueBase<System.String> {
		public Input_System_String valueInput;
		public Output_System_String valueOutput;

#if UNITY_EDITOR
		public override void Init() {
			SetName("String");
			valueOutput = CreateIO<Output_System_String>();
			valueInput = CreateIO<Input_System_String>();
		}
#endif

		public override void Calculate() {
			valueOutput.value = value;
		}

		public override NodeInput GetInput() { return valueInput; }
		public override NodeOutput GetOutput() { return valueOutput; }
	}
}
