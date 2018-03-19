namespace Observer_example
{
    interface IScreen
    {
        void Update(int places);
        void OnCarCrashHandler(string model, string number);
    }
}
