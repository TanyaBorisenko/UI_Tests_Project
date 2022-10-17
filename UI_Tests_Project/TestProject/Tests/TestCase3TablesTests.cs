using System.Collections.Generic;
using NUnit.Framework;
using UI_Tests_Project.FrameWork.Models;
using UI_Tests_Project.FrameWork.Models.Factory;
using UI_Tests_Project.TestProject.Pages;

namespace UI_Tests_Project.TestProject.Tests
{
    public class TestCase3TablesTests : BaseTest
    {
        private readonly MainPage _mainPage = new();
        private readonly WebTablesPage _webTablesPage = new();
        private readonly RegistrationFormPage _registrationFormPage = new();
        private readonly MenuForm _menuForm = new();

        [TestCaseSource(nameof(Test))]
        public void TestCase_3(UserModel user)
        {
            //Open main page
            Assert.IsTrue(_mainPage.IsPageOpened(), "Main page should open");

            //Open web tables form
            _mainPage.ClickElementsButton();
            _menuForm.ClickWebTablesButton();

            Assert.IsTrue(_webTablesPage.IsPageOpened(), "Web tables page should open");

            //Open registration form
            _webTablesPage.ClickAddButton();

            Assert.IsTrue(_registrationFormPage.IsPageOpened(), "Form should open");

            //Enter data and click submit
            _registrationFormPage.EnterDataClickSubmit(user);
            var checkCountRows = _webTablesPage.GetNumberOfFilledLines();

            Assert.IsTrue(_webTablesPage.CheckIsUserIsDisplayed(user), "User should be in table");

            //Delete user from table
            _webTablesPage.DeleteUser(user);
            var checkRowsAfterDeleteUser = _webTablesPage.GetNumberOfFilledLines();
            var result = checkRowsAfterDeleteUser < checkCountRows;

            Assert.IsTrue(result, "User must be removed from the table");
        }

        private static IEnumerable<UserModel> Test()
        {
            return UserFactory.GetUserModelsFromJson();
        }
    }
}