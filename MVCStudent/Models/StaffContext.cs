namespace MVCStudent.Models
{
    public class StaffContext
    {
        public static List<Staff> staffObject = new List<Staff>();
        public StaffContext()
        {
            if (staffObject.Count == 0)
            {
                staffObject.Add(new Staff(1, "Max", "Baby staff member ", "1234", "2004"));
                staffObject.Add(new Staff(2, "Chop", "Isla baby ", "Can't remember", "2014"));
                staffObject.Add(new Staff(3, "Kyle", "Mini staff member ", "Kyle", "1997"));
            }
        }
    }
}
