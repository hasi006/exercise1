using System;

namespace Stackoverflowpost
{
    public class Post
    {
        private string _title;
        private string _description;
        private readonly DateTime _createdDate;

        public Post(string title, string description,DateTime createdDate)
        {
            this._title = title;
            this._description = description;
            this._createdDate = createdDate;
        }

        public int VoteCount { get; private set; }

        public string Description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Description is required");

                _description = value;
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Title is required");

                _title = value;
            }
        }

        public DateTime CreatedDate
        {
            get { return _createdDate; }
        }


        public void UpVote()
        {
            VoteCount++;
        }

        public void DownVote()
        {
            VoteCount--;
        }
    }
}
