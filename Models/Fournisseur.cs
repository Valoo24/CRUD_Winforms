using System.Text;

namespace Models
{
    public class Fournisseur
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public int PostCode { get; private set; }
        public string Country { get; private set; }
        public bool IsWaitingForCommand { get; private set; }
        public DateTime? CreationDate { get; private set; }
        public DateTime? LastUpdatedDate { get; private set; }

        public Fournisseur (string FileLine)
        {
            string[] Elements = FileLine.Split(";");
            this.Id = int.Parse(Elements[0]);
            this.Name = Elements[1];
            this.Email = Elements[2];
            this.Street = Elements[3];
            this.City = Elements[4];
            this.PostCode = int.Parse(Elements[5]);
            this.Country = Elements[6];

            if(Elements[7] == CommandStatus.Oui.ToString())
            {
                this.IsWaitingForCommand = true;
            }
            else if(Elements[7] == CommandStatus.Non.ToString())
            {
                this.IsWaitingForCommand = false;
            }

            if (Elements.GetLength(0) > 9)
            {
                this.CreationDate = Convert.ToDateTime(Elements[8]);
                if(Elements.GetLength(0) > 10)
                {
                    this.LastUpdatedDate = Convert.ToDateTime(Elements[9]);
                }
            }
        }
        public Fournisseur(int FurnisherID, string FurnisherName, string FurnisherEmail, string FurnisherStreet, string FurnisherCity,
            int FurnisherPostCode, string FurnisherCountry, bool FurnisherIsWaitingForCommand)
        {
            this.Id = FurnisherID;
            this.Name = FurnisherName;
            this.Email = FurnisherEmail;
            this.Street=FurnisherStreet;
            this.City = FurnisherCity;
            this.PostCode = FurnisherPostCode;
            this.Country = FurnisherCountry;
            this.IsWaitingForCommand = FurnisherIsWaitingForCommand;
            this.CreationDate = DateTime.Now;
            SetNewUpdateDate();
        }
        public void SetNewUpdateDate()
        {
            this.LastUpdatedDate = DateTime.Now;
        }

        public override string ToString()
        {
            string FurnisherText = $"ID: {this.Id}\tNom: {this.Name}\tE-mail: {this.Email}\t Adresse: {this.Street},{this.PostCode} {this.City},{this.Country}\t";

            if(this.IsWaitingForCommand)
            {
                FurnisherText += "Attends une commande\t";
            }
            else if(!this.IsWaitingForCommand)
            {
                FurnisherText += "N'est pas en commande\t";
            }

            if(this.CreationDate != null)
            {
                FurnisherText += $"Crée le: {this.CreationDate}\t";
            }

            if(this.LastUpdatedDate != null)
            {
                FurnisherText += $"Mis à jour le: {this.LastUpdatedDate}";
            }

            return FurnisherText;
        }

        public string FurnisherToSaveText()
        {
            string SaveText;
            string CommandText;
            if(this.IsWaitingForCommand)
            {
                CommandText = CommandStatus.Oui.ToString();
            }
            else
            {
                CommandText = CommandStatus.Non.ToString();
            }

            SaveText = $"{this.Id};{this.Name};{this.Email};{this.Street};{this.City};{this.PostCode};{this.Country};{CommandText};" +
                $"{this.CreationDate};{this.LastUpdatedDate}";

            return SaveText;
        }

        public bool HasANameMinOfThreeChar()
        {
            Char[] TestArray = this.Name.ToCharArray();
            if (TestArray.GetLength(0) > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasAValidEMail()
        {
            IList<string> TestExtensionList;
            bool HasArrowBase = false;
            bool HasCorrectExtension = false;
            StringBuilder stringBuilder = new StringBuilder();
            Char[] TestArray = this.Email.ToCharArray();
            for(int i = 0; i < TestArray.GetLength(0); i++)
            {
                if (TestArray[i] == '@')
                {
                    HasArrowBase = true;
                }

                if(TestArray[i] == '.')
                {
                    for(int j = i + 1; j < TestArray.GetLength(0); j++)
                    {
                        stringBuilder.Append(TestArray[j]);
                    }
                }
            }

            foreach(string Extension in MailExtension.GetEmailExtensionList())
            {
                if (stringBuilder.ToString() == Extension)
                {
                    HasCorrectExtension = true;
                }
            }

            if(HasCorrectExtension && HasArrowBase)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}