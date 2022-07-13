namespace Logger {
    public interface ISinkHandler {
        void WriteMessage(string ns, string message);
    }
}