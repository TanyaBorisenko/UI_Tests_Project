using System;

namespace UI_Tests_Project.FrameWork.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
        public string Salary { get; set; }
        public string Department { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as UserModel;

            if (other is null)
            {
                throw new ArgumentNullException();
            }

            return FirstName.Equals(other.FirstName) &&
                   LastName.Equals(other.LastName) &&
                   Email.Equals(other.Email) &&
                   Age.Equals(other.Age) &&
                   Salary.Equals(other.Salary) &&
                   Department.Equals(other.Department);
        }
    }
}