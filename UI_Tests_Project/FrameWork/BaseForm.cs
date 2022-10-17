using UI_Tests_Project.FrameWork.Utils;

namespace UI_Tests_Project.FrameWork
{
    public abstract class BaseForm
    {
        private readonly BaseElement _uniqElement;
        protected DriverUtil DriverUtil => new DriverUtil();

        public BaseForm(BaseElement uniqElement, string pageName)
        {
            _uniqElement = uniqElement;
        }

        public bool IsPageOpened()
        {
            return _uniqElement.IsDisplayed();
        }
    }
}