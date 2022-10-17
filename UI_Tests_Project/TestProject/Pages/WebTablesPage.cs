using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using UI_Tests_Project.FrameWork;
using UI_Tests_Project.FrameWork.Models;
using UI_Tests_Project.FrameWork.Utils;

namespace UI_Tests_Project.TestProject.Pages
{
    public class WebTablesPage : BaseForm
    {
        private static Label Header => new(By.XPath("//div[@class='main-header'][contains(text(),'Web Tables')]"),
            "Web tables page header");

        private static Button AddButton => new(By.Id("addNewRecordButton"), "Add button");

        private static Label FilledLines =>
            new(By.XPath("//div[@class='rt-td']//span[contains(@title,'Delete')]"), "Filled lines");

        private static Button DeleteUserButton(string delete) =>
            new(
                By.XPath(
                    $"//div[@class='rt-tr-group']//*[contains(text(),'{delete}')]//following::span[contains(@title,'Delete')]"),
                "Delete button");

        private static Label TableRows =>
            new(By.XPath("//div[@class='action-buttons']//ancestor::div[contains(@class,'rt-tr-group')]"),
                "Filled table rows");

        public WebTablesPage() : base(Header, "Web tables form page")
        {
        }

        public void ClickAddButton()
        {
            AddButton.Click();
        }

        public int GetNumberOfFilledLines()
        {
            var emptyRows = FilledLines.FindElements().Count;
            return emptyRows;
        }

        public bool CheckIsUserIsDisplayed(UserModel newUser)
        {
            var usersInTable = GetAllUsersInTable();
            foreach (var user in usersInTable)
            {
                var compareUsers = user.Equals(newUser);
                if (compareUsers)
                {
                    return true;
                }
            }

            return false;
        }

        public IList<UserModel> GetAllUsersInTable()
        {
            IList<IWebElement> elements = new List<IWebElement>(TableRows.FindElements());
            var users = new List<UserModel>();

            if (elements.Count > 0)
            {
                foreach (var elementText in elements.Select(element => element.Text))
                {
                    var element = elementText;
                    var result = Parser.StringParse(element);
                    var user = new UserModel()
                    {
                        FirstName = result[0],
                        LastName = result[1],
                        Age = result[2],
                        Email = result[3],
                        Salary = result[4],
                        Department = result[5]
                    };
                    users.Add(user);
                }
            }

            return users;
        }

        public void DeleteUser(UserModel deleteUserName)
        {
            DeleteUserButton(deleteUserName.FirstName).MoveTo();
            DeleteUserButton(deleteUserName.FirstName).Click();
        }
    }
}