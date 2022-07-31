namespace ShareClassLibrary
{
    public class TeacherData:ImageBase
    {
        public string name { get; set; } = "";
        public List<string> introduction { get; set; } = new List<string>();
        public string fb { get; set; } = "";
        public string instagram { get; set; } = "";
    }
}