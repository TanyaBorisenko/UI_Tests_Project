using OpenQA.Selenium;
using UI_Tests_Project.FrameWork;
using UI_Tests_Project.FrameWork.Models;

namespace UI_Tests_Project.TestProject.Pages
{
    public class RegistrationFormPage : BaseForm
    {
        private static Label Header => new(By.Id("userForm"), "Registration form header");
        private static TextField FirstName => new(By.Id("firstName"), "First name");
        private static TextField LastName => new(By.Id("lastName"), "Last name");
        private static TextField UserEmail => new(By.Id("userEmail"), "User email");
        private static TextField Age => new(By.Id("age"), "Age");
        private static TextField Salary => new(By.Id("salary"), "Salary");
        private static TextField Department => new(By.Id("department"), "Department");
        private static Button SubmitButton => new(By.Id("submit"), "Submit button");

        public RegistrationFormPage() : base(Header, "Registration form")
        {
        }

        public void EnterDataClickSubmit(UserModel user)
        {
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            UserEmail.SendKeys(user.Email);
            Age.SendKeys(user.Age);
            Salary.SendKeys(user.Salary);
            Department.SendKeys(user.Department);
            SubmitButton.Click();
        }
    }
}