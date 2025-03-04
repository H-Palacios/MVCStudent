namespace MVCStudent.Models
{
    public class ModuleContext
    {
        public static List<Module> moduleObjects = new List<Module>();
        public ModuleContext()
        {
            if (moduleObjects.Count == 0)
            {
                moduleObjects.Add(new Module(1, "Cloud", 1, 60, "CR1"));
                moduleObjects.Add(new Module(2, "Chop", 2, 48, "CR2"));
                moduleObjects.Add(new Module(3, "Kyle", 3, 72, "CR3"));
            }
        }
    }
}
