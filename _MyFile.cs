// Important notes:
// - This class should have the same name as the file it's in
// - This inherits from ToSic.Sxc.Code.WithDnnContext
//   which will automatically provide the common objects like App, Dnn etc.
//   from the current context to use in your code

        public class _MyFile: ToSic.Sxc.Code.WithDnnContext {
  public string SayHello() {
    return "Hello from shared functions!";
    }
}
