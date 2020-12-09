namespace InnSchool
{
    public class Professor
    {
        public Professor()
        {

        }
        public string Name
        {
            set;
            get;
        }
        public int id
        {
            get;
            set;
        }
        public string profession
        {
            get;
            set;
        }
        public double salary
        {
            get;
            set;
        }
        public Professor(string Name, int id, string profession, double salary)
        {
            this.Name = Name;
            this.id = id;
            this.profession = profession;
            this.salary = salary;
        }

    }
}