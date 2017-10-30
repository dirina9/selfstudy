namespace Observer_example
{
    interface IScreens
    {
        void Update(int places);
        void Attention(Parking.CarCrashEventArgs carCrashEventArgs);
    }
}
