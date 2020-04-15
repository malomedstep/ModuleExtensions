using ExtensionAdapter;

namespace ToUpper {
    public class ToLowerModule : IFunctionModule {
        public FunctionInfo GetModuleFunctionInfo() {
            return new FunctionInfo {
                ButtonText = "To upper",
                Function = ProcessInput
            };
        }

        private string ProcessInput(string arg) {
            return arg.ToLower();
        }
    }
}