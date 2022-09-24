using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationStateProject
{
    public class User
    {
        public string Name { get; set; }
        public User(string name)
        {
            Name = name;
        }
    }

    public class Company
    {
        User[] users = new User[3];

        string title;
        string phone;
        string email;
        public Company(User[] users)
        {
            this.users = users;
        }

        public User this[int index]
        {
            set
            {
                if(index >= 0 && index < users.Length)
                    users[index] = value;
            }
            get
            {
                if (index >= 0 && index < users.Length)
                    return users[index];
                else
                    throw new IndexOutOfRangeException();
            }
        }

        public string this[string index]
        {
            set
            {
                switch (index)
                {
                    case "title": title = value; break;
                    case "phone": phone = value; break;
                    case "email": email = value; break;
                    default:
                        break;
                }
            }
            get
            {
                switch (index)
                {
                    case "title": return title; break;
                    case "phone": return phone; break;
                    case "email": return email; break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }

    }

}
