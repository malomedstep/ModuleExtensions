using ExtensionAdapter;

namespace ToLower {
    public class ToLowerModule : IFunctionModule {
        public FunctionInfo GetModuleFunctionInfo() {
            return new FunctionInfo {
                ButtonText = "To lower",
                Function = (input) => input.ToLower()
            };
        }
    }
}
