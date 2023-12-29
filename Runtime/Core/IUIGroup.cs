namespace EnaKit.UI
{
    public interface IUIGroup
    {
        int Id
        {
            get;
        }
        
        string Name
        {
            get;
        }

        int Depth
        {
            get;
            set;
        }

        bool Pause
        {
            get;
            set;
        }

        int UIElementCount
        {
            get;
        }

        bool HasUIElement(int UIElementId);

        bool HasUIElement(string UIElementName);

        IUIElement GetUIElement(int UIElementId);
        
        IUIElement[] GetUIElement(string UIElementName);
        
        IUIElement[] GetAllUIElements();
    }
}