using Newtonsoft.Json;

namespace UI_Tests_Project.FrameWork.Utils
{
    public class NewtonSoftJsonSerializer
    {
        private NewtonSoftJsonSerializer()
        {
        }

        public static NewtonSoftJsonSerializer Default => new NewtonSoftJsonSerializer();

        public T Deserialize<T>(string content)
        {
            var deserializeObject = JsonConvert.DeserializeObject<T>(content);

            return deserializeObject;
        }
    }
}