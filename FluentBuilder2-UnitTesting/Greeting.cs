
namespace FluentBuilder2_UnitTesting
{
    public sealed class Greet
    {
        public string TimeOfDay;
        public string To;

        public string Message => $"Buenas {TimeOfDay} {To}";
    }
}
