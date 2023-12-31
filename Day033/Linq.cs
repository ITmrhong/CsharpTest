namespace ConsoleApp31
{
    internal class Program
    {
        class Profile
        {
            public string Name { get; set; }
            public int Height { get; set; }
        }
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile() {Name="정우성",Height=186},
                new Profile() {Name="김태희",Height=158},
                new Profile() {Name="고현정",Height=172},
                new Profile() {Name="이문세",Height=178},
                new Profile() {Name="하하",Height=172},
            };
            var profiles = from profile in arrProfile
                           where profile.Height>=178
                           orderby profile.Height
                           select profile;

            foreach (var p in profiles)
                Console.WriteLine($"{p.Name} {p.Height}");
        }
    }
}
