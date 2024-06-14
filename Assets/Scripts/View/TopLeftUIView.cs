using System.ComponentModel;
using ViewModel.Extensions;
using UnityEngine;
using UnityEngine.UI;

public class TopLeftUIView : MonoBehaviour
{
    [SerializeField] Text Text_Name;
    [SerializeField] Text Text_Level;
    [SerializeField] Image Img_Icon;

    // ����� ���Եȴ�
    private TopLeftUIViewModel m_viewModel;

    private void OnEnable()
    {
        if (m_viewModel == null)
        {
            m_viewModel = new TopLeftUIViewModel();
            m_viewModel.PropertyChanged += OnPropertyChanged;
            m_viewModel.RegisterEventOnEnable();
            m_viewModel.RefreshViewModel();
            
        }
    }

    private void OnDisable()
    {
        if (m_viewModel != null)
        {
            m_viewModel.UnRegisterEventOnDisable();
            m_viewModel.PropertyChanged -= OnPropertyChanged;
            m_viewModel = null;
        }
    }

    // View�� ���� ��� ó���� �Ʒ��� �ڵ忡 Ȯ�� ����
    private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
    {
        switch (args.PropertyName)
        {
            case nameof(m_viewModel.Name):
                Text_Name.text = $"Name : {m_viewModel.Name}";
                // Name View�� ó��
                break;
            case nameof(m_viewModel.Level):
                Text_Level.text = $"LV : {m_viewModel.Level}";
                // Level View�� ó��
                break;
            case nameof(m_viewModel.IconName):
                // IconName View�� ó��
                break;
        }
    }


}
