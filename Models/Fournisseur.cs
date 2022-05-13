namespace Models
{
    public class Fournisseur
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public bool IsWaitingForCommand { get; private set; }
        public DateTime CreationDate { get; private set; }
        public DateTime LastUpdatedDate { get; private set; }
    }
}