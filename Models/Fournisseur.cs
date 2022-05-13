﻿namespace Models
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
            if(Elements[7] == "Oui")
            {
                this.IsWaitingForCommand = true;
            }
            else if(Elements[7] == "Non")
            {
                this.IsWaitingForCommand = false;
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
            string FurnisherText = $"{this.Id}\t{this.Name}\t{this.Email}\t{this.Street}\t{this.City}\t{this.PostCode}\t{this.Country}\t";

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
                FurnisherText += $"{this.CreationDate}\t";
            }

            if(this.LastUpdatedDate != null)
            {
                FurnisherText += $"{this.LastUpdatedDate}";
            }

            return FurnisherText;
        }
    }
}