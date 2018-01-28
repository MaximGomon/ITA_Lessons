namespace DapperSample
{
    public class StudentDetailed
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Cource { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{FullName}\t{Cource}";
        }
    }
}