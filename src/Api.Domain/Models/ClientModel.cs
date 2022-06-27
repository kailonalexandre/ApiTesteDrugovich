using System;

namespace Domain.Models
{
    public class ClientModel
    {
        private Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _cnpj;

        public string Cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        private DateTime _createAt;

        public DateTime CreateAt
        {
            get { return _createAt; }
            set
            {
                _createAt = value == null ? DateTime.UtcNow : value;
            }
        }

        private DateTime _fundationDate;

        public DateTime FundationDate
        {
            get { return _fundationDate; }
            set
            {
                _fundationDate = value == null ? DateTime.UtcNow : value;
            }
        }

        private Guid _groupId;

        public Guid GroupId
        {
            get { return _groupId; }
            set { _groupId = value; }
        }

        private DateTime dateTime;

        public DateTime UpdateTime
        {
            get { return dateTime; }
            set
            {
                dateTime = value == null ? DateTime.UtcNow : value;
            }
        }
    }
}
