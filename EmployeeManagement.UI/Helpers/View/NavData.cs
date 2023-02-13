namespace EmployeeManagement.UI.Helpers.View
{
    public class NavObject
    {
        public string? Text { get; set; }
        public string? Url { get; set; }
    }
    public  class NavData
    {
        public static List<NavObject> NavItems = new List<NavObject>()
        {
            new NavObject{Text="Dashboard",Url = "/dashboard"},
            new NavObject{Text="Team",Url = "/team"},
            new NavObject{Text="Project",Url = "/project"},
            new NavObject{Text="Attendance History",Url = "/attendance"},
        };
    }
}
