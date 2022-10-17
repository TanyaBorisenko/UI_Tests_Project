using System.Collections.Generic;
using UI_Tests_Project.FrameWork.Utils;

namespace UI_Tests_Project.FrameWork.Models.Factory
{
    public static class UserFactory
    {
        public static IList<UserModel> GetUserModelsFromJson()
        {
            var jsonContent = FileReader.ReadFileProjectRoot("dataSettings.json");
            var users = NewtonSoftJsonSerializer.Default.Deserialize<IList<UserModel>>(jsonContent);

            return users;
        }
    }
}