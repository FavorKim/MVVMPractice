using System.ComponentModel;

public class TopLeftUIViewModel
{
    private int m_userId;
    private string m_name;
    private int m_level;
    private string m_iconName;

    public int UserId
    {
        get { return m_userId; }
        set { m_userId = value; }
    }


    public string Name
    {
        get { return m_name; }
        set
        {
            if (m_name == value) // 변경되지 않았다면 무시
                return;
            m_name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    public int Level
    {
        get { return m_level; }
        set
        {
            if (m_level == value) 
                return;
            m_level = value;
            OnPropertyChanged(nameof(Level));
        }
    }

    public string IconName
    {
        get { return m_iconName; }
        set
        {
            if (m_iconName == value)
                return;
            m_iconName = value;
            OnPropertyChanged(nameof(IconName));
        }
    }

    #region PropChanged
    public event PropertyChangedEventHandler PropertyChanged;
    
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion

}
