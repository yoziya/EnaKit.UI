namespace EnaKit.UI
{
    public interface IUIElement
    {
        int Id
        {
            get;
        }
        
        string Name
        {
            get;
        }
        
        object Object
        {
            get;
        }
        
        IUIGroup UIGroup
        {
            get;
        }
        
        int DepthInUIGroup
        {
            get;
        }

        void Init();

        void Recycle();

        void Open();

        void Close();

        void Pause();

        void Resume();

        void Refresh();

        void Update();
        
        void DepthInUIGroupChanged(int uiGroupDepth, int depthInUIGroup);
    }
}