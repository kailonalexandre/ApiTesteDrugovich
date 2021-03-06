using System;

namespace Domain.Models
{
    public class GroupModel
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


        private DateTime _createAt;

        public DateTime CreateAt
        {
            get { return _createAt; }
            set
            {
                _createAt = value == null ? DateTime.UtcNow : value;
            }
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
