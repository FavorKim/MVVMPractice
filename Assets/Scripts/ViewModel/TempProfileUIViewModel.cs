

using System.ComponentModel;

public class TempProfileUIViewModel
{
    private int m_userId;
    private string m_playerName;
    private int m_level;

    public int UserId { get; set; }
    
    public string Name
    {
        get { return m_playerName; } 
        set
        {
            if(m_playerName != value)
            {
                m_playerName = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    }
    public int Level
    {
        get { return m_level; }
        set
        {
            if(m_level != value)
            {
                m_level = value;
                OnPropertyChanged(nameof(Level));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged(string propertyName)
    {
        
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
