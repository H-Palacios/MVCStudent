namespace MVCStudent.Models
{
    public class Module
    {
        public int ModuleCode { get; set; }
        public string Name { get; set; }
        public int StaffId { get; set; }
        public int Hours { get; set; }
        public string Venue { get; set; }
        public Module()
        {
        }
        public Module(int moduleCode, string name, int staffId, int hours, string venue)
        {
            this.ModuleCode = moduleCode;
            this.Name = name;
            this.StaffId = staffId;
            this.Hours = hours;
            this.Venue = venue;
        }
    }
}
