

using System.ComponentModel;

public class TempProfileUIViewModel
{
    private string m_playerName;
    private int m_userId;

    public int UserId { get; set; }
    
    public string PlayerName
    {
        get { return m_playerName; } 
        set
        {
            if(m_playerName != value)
            {
                m_playerName = value;
                OnPropertyChanged(nameof(PlayerName));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
