namespace MVCStudent.Models
{
    public class Staff
    {
        int id;
        string name;
        string title;
        string pssword;
        string dob;
        public Staff()
        {

        }
        public Staff(int id, string name, string title, string pssword, string dob)
        {
            this.Id = id;
            this.Name = name;
            this.Title = title;
            this.Pssword = pssword;
            this.Dob = dob;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Title { get => title; set => title = value; }
        public string Pssword { get => pssword; set => pssword = value; }
        public string Dob { get => dob; set => dob = value; }
    }
}
